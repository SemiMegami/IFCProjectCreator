using Microsoft.SqlServer.Management.XEvent;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Serialization;
using static Azure.Core.HttpHeader;

namespace IFCProjectCreator
{
    public class IFCDataSet
    {
        public readonly string globalName = "Global";
        public readonly string IFCName = "IFC";

        public readonly Dictionary<string, string> CSharpBasicDataTypes = new Dictionary<string, string>()
        {
            { "REAL", "double" },
            { "INTEGER", "int" },
            { "NUMBER", "double" },
            { "LOGICAL", "bool" },
            { "BOOLEAN", "bool" },
            { "BINARY", "int" },
            { "STRING", "string" },
        };
        public readonly Dictionary<string, string> CSharpBasicDataDefaultValue = new Dictionary<string, string>()
        {
            { "REAL", "0" },
            { "INTEGER", "0" },
            { "NUMBER", "0" },
            { "LOGICAL", "false" },
            { "BOOLEAN", "false" },
            { "BINARY", "0" },
            { "STRING", "\"\"" },
        };
        public string NamespaceName;
        public List<IFCBasicType> BasicTypes { get; private set; }
        public List<IFCBasicTypeList> BasicTypeLists { get; private set; }
        public List<IFCEnumType> EnumTypes { get; private set; }
        public List<IFCSelectType> SelectTypes { get; private set; }
        public List<IFCEntity> Entities { get; private set; }
        public List<IFCFunction> Functions { get; private set; }
        public List<string> Versions { get; private set; }

        public List<IFCSelectType> GlobalSelectTypes { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public IFCDataSet()
        {
            BasicTypes = new List<IFCBasicType>();
            BasicTypeLists = new List<IFCBasicTypeList>();
            EnumTypes = new List<IFCEnumType> ();
            SelectTypes = new List<IFCSelectType>();
            Entities = new List<IFCEntity>();
            Functions = new List<IFCFunction>();
            Versions = new List<string> ();
            GlobalSelectTypes = new List<IFCSelectType> ();
            NamespaceName = "";
        }

        /// <summary>
        /// Read an EXP file to store data
        /// </summary>
        /// <param name="path">File Path</param>
        /// <param name="version">Version Name</param>
        public void ReadData(string path, string version)
        {
            ReadEXP(path, version);
            SetParent();
            SetAtribute();
            SetSelectType();
            
        }


        /// <summary>
        /// Read an EXP file to store data
        /// </summary>
        /// <param name="path">File Path</param>
        /// <param name="version">Version Name</param>
        private void ReadEXP(string path, string version)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                if (reader != null)
                {
                    Versions.Add(version);
                    string line;
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine() ?? "";
                        if (line != null)
                        {
                            line = line.Trim();

                            string[] words = line.Split(' ');

                            if (words.Length > 0)
                            {
                                IFCClass? item = null;
                                switch (words[0])
                                {
                                    case "TYPE":
                                        if (line.Contains("ENUMERATION OF"))
                                        {
                                            item = new IFCEnumType(this, version);
                                            EnumTypes.Add((IFCEnumType)item);
                                        }
                                        else if (line.Contains(" = SELECT"))
                                        {
                                            item = new IFCSelectType(this, version);
                                            SelectTypes.Add((IFCSelectType)item);
                                        }
                                        else if (line.Contains("]"))
                                        {
                                            item = new IFCBasicTypeList(this, version);
                                            BasicTypeLists.Add((IFCBasicTypeList)item);
                                        }
                                        else
                                        {
                                            item = new IFCBasicType(this, version);
                                            BasicTypes.Add((IFCBasicType)item);
                                        }
                                        break;
                                    case "ENTITY":
                                        item = new IFCEntity(this, version);
                                        Entities.Add((IFCEntity)item);
                                        break;
                                    case "FUNCTION":
                                        item = new IFCFunction(this, version);
                                        Functions.Add((IFCFunction)item);
                                        break;
                                    default:
                                        break;
                                }
                                item?.ReadEXP(reader, line);
                            }
                        }
                    }
                    reader.Close();
                }
            }
        }

        /// <summary>
        /// Link parents
        /// </summary>
        private void SetParent()
        {
            List<IFCClass> items = GetItems();

            foreach (var selectType in SelectTypes)
            {
                foreach (var subClassName in selectType.SubClassesNames)
                {
                    IFCClass subClass = items.First(e => e.Name == subClassName && e.VersionName == selectType.VersionName);
                    if (!subClass.InterfaceNames.Contains(selectType.Name))
                    {
                        subClass.InterfaceNames.Add(selectType.Name);
                        subClass.ParentSelects.Add(selectType);
                        selectType.SubClasses.Add(subClass);
                    }
                }
            }
            foreach (var entity in Entities)
            {
                List<IFCEntity> parents = Entities.Where(e => e.Name == entity.ParentName && e.VersionName == entity.VersionName).ToList();
                if (parents.Count > 0)
                {
                    IFCEntity parent = parents.First();
                    entity.ParentClass = parent;
                    if (!parent.SubClassesNames.Contains(entity.Name))
                    {
                        parent.SubClassesNames.Add(entity.Name);
                        parent.SubClasses.Add(entity);
                    }
                }
            }
            foreach (var basicType in BasicTypes)
            {
                List<IFCBasicType> parents = BasicTypes.Where(e => e.Name == basicType.ParentName && e.VersionName == basicType.VersionName).ToList();
                if (parents.Count > 0)
                {
                    IFCBasicType parent = parents.First();
                    basicType.ParentClass = parent;
                    parent.SubClassesNames.Add(basicType.Name);
                    parent.SubClasses.Add(basicType);
                }
            }

           
        }

        private void SetSelectType()
        {
            foreach (var selectType in SelectTypes)
            {
                var allSubClasses = selectType.GetAllSubClasses();

                List<IFCEntity> subEntities = new List<IFCEntity>();
                if (allSubClasses.Where(e => e is IFCBasicType || e is IFCBasicTypeList).Count() > 0)
                {
                    continue;
                }
                foreach (var subclass in allSubClasses)
                {
                    if (subclass is IFCEntity subEntity)
                    {
                        if (subEntity.SubClasses.Count == 0)
                        {
                            subEntities.Add(subEntity);
                        }
                    }
                }
                List<List<IFCAttribute>> attributesSets = new List<List<IFCAttribute>>();
                foreach (var subEntity in subEntities)
                {
                    attributesSets.Add(subEntity.AllAttributes);
                }
                List<string> attributesNames = new List<string>();
                if (attributesSets.Count > 0)
                {
                    foreach (var attributes in attributesSets)
                    {
                        foreach (var attribute in attributes)
                        {
                            if (!attributesNames.Contains(attribute.Name))
                            {
                                attributesNames.Add(attribute.Name);
                            }
                        }
                    }
                    List<IFCAttribute> commonAttributes = new List<IFCAttribute>();

                    foreach (var attributeName in attributesNames)
                    {
                        bool isCommon = true;
                        bool isReadonly = false;
                        foreach (var attributes in attributesSets)
                        {
                            if (attributes.FirstOrDefault(e => e.Name == attributeName) == null)
                            {
                                isCommon = false;
                            }
                        }
                        if (isCommon)
                        {
                            var attribute0 = attributesSets[0].First(e => e.Name == attributeName);
                            foreach (var attributes in attributesSets)
                            {
                                var attribute = attributes.First(e => e.Name == attributeName);

                                if (attribute0.TypeName != attribute.TypeName || attribute0.Aggregation != attribute.Aggregation || attribute0.AttributeType != attribute.AttributeType)
                                {
                                    isCommon = false;
                                }
                                if (attribute.isReadOnly)
                                {
                                    isReadonly = true;
                                }
                            }
                        }

                        if (isCommon)
                        {
                            commonAttributes.Add(attributesSets[0].First(e => e.Name == attributeName));

                            var attribute = attributesSets[0].First(e => e.Name == attributeName);
                            if (selectType.SelectAttributes.FirstOrDefault(e => e.Name == attribute.Name) == null)
                            {
                                selectType.SelectAttributes.Add(new IFCSelectAttribute()
                                {
                                    Name = attribute.Name,
                                    TypeName = attribute.TypeName,
                                    Aggregation = attribute.Aggregation,
                                    AttributeType = attribute.AttributeType,
                                    isReadOnly = isReadonly
                                });
                            }
                        }
                    }
                }
            }

            // update readOnly
            foreach (var entity in Entities)
            {
                var entityAttributes = entity.AllAttributes.Where(e => e is IFCDerivedAttribute || e is IFCInverseAttribute).ToList();
                if(entity.Name == "IFCAxis2Placement2D")
                {

                }
                foreach (var parent in entity.AllParentSelects)
                {
                    foreach (var attribute in entityAttributes)
                    {
                        var parentAttribute = parent.SelectAttributes.FirstOrDefault(e=>e.Name == attribute.Name);
                        if(parentAttribute != null)
                        {
                            parentAttribute.isReadOnly = true;
                        }
                    }
                  
                }
            }

                // Additional select attribute
                foreach (var entity in Entities)
            {
                var allAttribute = entity.AllAttributes;
                Dictionary<string, IFCSelectAttribute> selectarributeDict = new Dictionary<string, IFCSelectAttribute>();

                var parents = entity.AllParentSelects;
                foreach (var parent in parents)
                {
                    foreach (var attribute in parent.SelectAttributes)
                    {
                        if (!(selectarributeDict.ContainsKey(attribute.Name)))
                        {
                            selectarributeDict.Add(attribute.Name, attribute);
                        }
                    }
                }
                foreach (var att in selectarributeDict)
                {
                    var attribute = att.Value;

                    if (allAttribute.FirstOrDefault(e => e.Name == attribute.Name) == null && entity.AdditionalSelectAttibutes.FirstOrDefault(e => e.Name == attribute.Name) == null)
                    {
                        entity.AdditionalSelectAttibutes.Add(new IFCSelectAttribute()
                        {
                            Name = attribute.Name,
                            TypeName = attribute.TypeName,
                            Aggregation = attribute.Aggregation,
                            AttributeType = attribute.AttributeType,
                            isClassAttribute = true,
                        });
                    }
                }
            }
            foreach (var enumType in EnumTypes)
            {
                Dictionary<string, IFCSelectAttribute> selectarributeDict = new Dictionary<string, IFCSelectAttribute>();

                var parents = enumType.AllParentSelects;
                foreach (var parent in parents)
                {
                    foreach (var attribute in parent.SelectAttributes)
                    {
                        if (!(selectarributeDict.ContainsKey(attribute.Name)))
                        {
                            selectarributeDict.Add(attribute.Name, attribute);
                        }
                    }
                }
                foreach (var att in selectarributeDict)
                {
                    var attribute = att.Value;

                    if (enumType.AdditionalSelectAttibutes.FirstOrDefault(e => e.Name == attribute.Name) == null)
                    {
                        enumType.AdditionalSelectAttibutes.Add(new IFCSelectAttribute()
                        {
                            Name = attribute.Name,
                            TypeName = attribute.TypeName,
                            Aggregation = attribute.Aggregation,
                            AttributeType = attribute.AttributeType,
                            isClassAttribute = true,
                        });
                    }
                }
            }
        }

        public void SetGlobal()
        {
            Dictionary<string, IFCSelectType> globalTypes = new Dictionary<string, IFCSelectType> ();
            List<IFCClass> items = GetItems();

            foreach (var item in items)
            {
                if (!globalTypes.ContainsKey(item.Name))
                {
                    IFCSelectType newType = new IFCSelectType(this, globalName) 
                    { 
                        Name = item.Name,
                        IsGlobal = true,
                    };
                    globalTypes.Add(item.Name, newType);
                }
                IFCSelectType global = globalTypes[item.Name];


            }
            GlobalSelectTypes = globalTypes.Values.ToList();

            foreach (var globalSelectType in GlobalSelectTypes)
            {
                List < IFCClass > typeitems = items.Where(e => e.Name == globalSelectType.Name).ToList();
                if (typeitems.Count > 0)
                {
                    if (typeitems[0] is IFCBasicTypeList basicTypeList)
                    {
                        string cSharpType = basicTypeList.GetCSharpType();
                        if (cSharpType.Length > 0)
                        {
                            globalSelectType.SelectAttributes.Add(new IFCSelectAttribute() { Name = "Value", TypeName = basicTypeList.GetCSharpType() });
                        }
                    }

                    else if (typeitems[0] is IFCBasicType basicType)
                    {
                        string cSharpType = basicType.GetCSharpType();
                        bool found = false;
                        foreach (var item in typeitems)
                        {
                            if (item is IFCBasicType basicType1)
                            {
                                if (basicType1.GetCSharpType() != cSharpType)
                                {
                                    found = true;
                                }
                            }
                            else
                            {
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            globalSelectType.SelectAttributes.Add(new IFCSelectAttribute() { Name = "Value", TypeName = cSharpType });
                        }
                    }

                    else if (typeitems[0] is IFCEnumType enumType)
                    {
                        List<IFCEnumType> enumItems = new List<IFCEnumType>();
                        bool found = false;
                        List<string> values = new List<string>();
                        foreach (var typeItem in typeitems)
                        {
                            if (typeItem is IFCEnumType enumType1)
                            {
                                enumItems.Add(enumType1);
                            }
                            else
                            {
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            foreach (var enumValue in enumType.EnumValues)
                            {
                                bool canAdd = true;
                                foreach (var item in enumItems)
                                {
                                    if (!item.EnumValues.Contains(enumValue))
                                    {
                                        canAdd = false;
                                    }
                                }
                                if (canAdd)
                                {
                                    globalSelectType.SelectAttributes.Add(new IFCSelectAttribute() { Name = enumValue, TypeName = "static string" });
                                }
                            }

                            globalSelectType.SelectAttributes.Add(new IFCSelectAttribute() { Name = "Value", TypeName = "string" });
                        }
                    }
                    else if (typeitems[0] is IFCSelectType selectType)
                    {
                        List<IFCSelectType> selectItems = new List<IFCSelectType>();
                        bool found = false;
                        bool isReadOnly = false;
                        foreach (var typeItem in typeitems)
                        {
                            if (typeItem is IFCSelectType selectType1)
                            {
                                selectItems.Add(selectType1);
                            }
                            else
                            {
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            foreach (var attribute in selectType.AllSelectAttributes)
                            {
                                bool canAdd = true;
                                foreach (var item in selectItems)
                                {
                                    var compareItem = item.AllSelectAttributes.FirstOrDefault(e => e.isSameAttribute(attribute));
                                    if (compareItem == null)
                                    {
                                        canAdd = false;
                                    }
                                }
                                if (canAdd)
                                {
                                    foreach (var item in selectItems)
                                    {
                                        var compareItem = item.AllSelectAttributes.FirstOrDefault(e => e.isSameAttribute(attribute));
                                        if (compareItem != null)
                                        {
                                            compareItem.includedInGlobal = true;
                                            if (compareItem.isReadOnly)
                                            {
                                                isReadOnly = true;
                                            }
                                        }
                                    }
                                    globalSelectType.SelectAttributes.Add(new IFCSelectAttribute()
                                    {
                                        Name = "_" + attribute.Name,
                                        TypeName = attribute.TypeName,
                                        Aggregation = attribute.Aggregation,
                                        AttributeType = attribute.AttributeType,
                                        isReadOnly = isReadOnly
                                    });
                                }
                            }
                        }
                    }

                    else if (typeitems[0] is IFCEntity entity)
                    {
                        List<IFCEntity> entities = new List<IFCEntity>();
                        bool found = false;
                        bool isReadOnly = false;
                        foreach (var typeItem in typeitems)
                        {
                            if (typeItem is IFCEntity entity1)
                            {
                                entities.Add(entity1);
                            }
                            else
                            {
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            foreach (var attribute in entity.AllAttributes)
                            {
                                bool canAdd = true;
                                foreach (var item in entities)
                                {
                                    var compareItem = item.AllAttributes.FirstOrDefault(e => e.isSameAttribute(attribute));
                                    if (compareItem == null)
                                    {
                                        canAdd = false;
                                    }
                                }
                                if (canAdd)
                                {
                                    foreach (var item in entities)
                                    {
                                        var compareItem = item.AllAttributes.FirstOrDefault(e => e.isSameAttribute(attribute));
                                        if (compareItem != null)
                                        {
                                            compareItem.includedInGlobal = true;
                                            if (compareItem.isReadOnly)
                                            {
                                                isReadOnly = true;
                                            }
                                        }
                                    }
                                    globalSelectType.SelectAttributes.Add(new IFCSelectAttribute()
                                    {
                                        Name = "_" + attribute.Name,
                                        TypeName = attribute.TypeName,
                                        Aggregation = attribute.Aggregation,
                                        AttributeType = attribute.AttributeType,
                                        isReadOnly = isReadOnly,
                                    });
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Link arribute 
        /// </summary>
        private void SetAtribute()
        {
            foreach (var entity in Entities)
            {
                List<IFCEntity> parents = entity.ParentClasses;
                foreach (var attribute in entity.DeriveClassAttributes)
                {
                    
                    foreach(var parent in parents)
                    {
                        if(parent.DeriveClassAttributes.Where(x=>x.Name == attribute.Name).Count() >0)
                        {
                            attribute.isOverride = true;
                        }
                        if (parent.DirectAttributes.Where(x => x.Name == attribute.Name).Count() > 0)
                        {
                            attribute.isOverride = true;
                        }
                        if (parent.AdditionalSelectAttibutes.Where(x => x.Name == attribute.Name).Count() > 0)
                        {
                            attribute.isOverride = true;
                        }
                    
                    }
                }
                foreach (var attribute in entity.DirectAttributes)
                {
                    foreach (var parent in parents)
                    {
                        if (parent.AdditionalSelectAttibutes.Where(x => x.Name == attribute.Name).Count() > 0)
                        {
                            attribute.isOverride = true;
                        }
                    }
                }
                foreach (var attribute in entity.InverseClassAttributes)
                {
                    var relatingEntity = Entities.Where(x => x.Name == attribute.TypeName && x.VersionName == entity.VersionName).ToList()[0];
                    var parameterAttributes = relatingEntity.DirectAttributes;
                    foreach(var param in parameterAttributes)
                    {
                        if(param.Name == attribute.RelatedAttributeName)
                        {
                            attribute.RelatedAttribute = param;
                        }
                    }
                }

                foreach (var attribute in entity.WhereClassAttributes)
                {
                    foreach (var parent in parents)
                    {
                        if (parent.WhereAttributes.Where(x => x.Name == attribute.Name).Count() > 0)
                        {
                            attribute.isOverride = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Get all Items
        /// </summary>
        /// <returns></returns>
        public List<IFCClass> GetItems()
        {
            List<IFCClass> items = new List<IFCClass>();
            items.AddRange(BasicTypes);
            items.AddRange(BasicTypeLists);
            items.AddRange(EnumTypes);
            items.AddRange(SelectTypes);
            items.AddRange(Entities);
            return items;
        }

        /// <summary>
        /// Get Item for Specific version
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<IFCClass> GetItems(string version) { 

            if(version == globalName)
            {
                List<IFCClass> classes = new List<IFCClass>();
                foreach (var g in GlobalSelectTypes)
                {
                    classes.Add(g);
                }
                return classes;
            }
            else
            {
                return GetItems().Where(e => e.VersionName == version).ToList();
            }
            
        }

        /// <summary>
        /// Write C# classes file in specificed folder
        /// </summary>
        /// <param name="folderDir"></param>
        public void WriteCSharp(string folderDir, string nameSpaceName)
        {
            NamespaceName = nameSpaceName;
            WriteCSharpModel(folderDir, nameSpaceName);
            WriteCSharpClassEntity(folderDir, nameSpaceName);
            WriteCSharpEntity(folderDir, nameSpaceName);
            WriteCSharpEnum(folderDir, nameSpaceName);

            WriteCSharpBasicType(folderDir, nameSpaceName);
            WtiteCSharpAttributes(folderDir, nameSpaceName);
            WriteCSharpAttribute(folderDir, nameSpaceName);
            foreach (var version in Versions)
            {
                WriteCSharp(folderDir, nameSpaceName, version);
            }
            WriteCSharp(folderDir, nameSpaceName, globalName);
        }

        /// <summary>
        /// Write C# classes file in specificed folder
        /// </summary>
        /// <param name="folderDir"></param>
        public void WriteCSharp(string folderDir, string nameSpaceName, string version)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + (version == globalName?"IFC_":"") + version + ".cs"))
            {
                var items = GetItems(version);
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName + "." + version);
                writer.WriteLine("{");


                writer.WriteLine("\t#region ---- SIMPLE DATA TYPES ----");
                foreach (var item in items.Where(e=>e is IFCBasicType || e is IFCBasicTypeList).ToList())
                {
                    var texts = item.GetCSharpTexts();
                    foreach (var text in texts)
                    {
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("\t#endregion");
                writer.WriteLine("");
                writer.WriteLine("\t#region ---- ENUMERATION TYPES ----");
                foreach (var item in items.Where(e => e is IFCEnumType).ToList())
                {
                    var texts = item.GetCSharpTexts();
                    foreach (var text in texts)
                    {
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("\t#endregion");
                writer.WriteLine("");
                writer.WriteLine("\t#region ---- INTERFACES ----");
                foreach (var item in items.Where(e => e is IFCSelectType).ToList())
                {
                    var texts = item.GetCSharpTexts();
                    foreach (var text in texts)
                    {
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("\t#endregion");
                writer.WriteLine("");
                writer.WriteLine("\t#region ---- ENTITY ----");
                foreach (var item in items.Where(e => e is IFCEntity).ToList())
                {
                    var texts = item.GetCSharpTexts();
                    foreach (var text in texts)
                    {
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("\t#endregion");
                writer.WriteLine("");
                writer.WriteLine("\t#region ---- FUNCTION ----");
                writer.WriteLine("\tpublic abstract class " + IFCName + "_Function : IFC_ClassEntity");
                writer.WriteLine("\t{");
                foreach (var f in Functions.Where(e => e.VersionName == version).ToList())
                {
                    var texts = f.GetCSharpTexts();
                    foreach (var text in texts)
                    {
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("\t}");
                writer.WriteLine("\t#endregion");
                writer.WriteLine("}");
            }
        }

        private void WriteCSharpModel(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_Model.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("using System.Linq;");
                writer.WriteLine("using System.Text;");
                writer.WriteLine("using System.Threading.Tasks;");
                writer.WriteLine("using System.IO;");
                writer.WriteLine("using System.Reflection;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic class IFC_Model");
                writer.WriteLine("\t{");


                WriteCSharpModelConstructure(nameSpaceName, writer);


                string contain =
        @"
        

        /// <summary>
        /// Return IFC Item with specified type
        /// </summary>
        /// <typeparam name=""T""></typeparam>
        /// <returns></returns>
        public List<T> GetItems<T>() where T : IFC_Entity
		{
			List<IFC_Entity> itemList = items.Values.Where(x => x is T).ToList();
            List <T> results = new List<T>();
			foreach (var item in itemList)
			{
				results.Add((T)item);
			}
			return results;
        }

        void CheckAndAddItem(dynamic parameter)
        {
            if (parameter == null)
            {
                return;
            }
            if(parameter != null)
            {
                if (parameter is IFC_ClassEntity entity)
                {
                    if (entity.Model != this)
                    {
                        AddItem(entity);
                    }
                }
                else if (parameter.GetType().GetInterface(""IEnumerable"") != null)
                {
                    for (int i = 0; i < parameter.Count; i++)
                    {
                        CheckAndAddItem(parameter[i]);
                    }
                }
            }
        }

        public static string GenerateID()
        {
            return Guid.NewGuid().ToString().Replace(""-"", """").Substring(0, 22);
        }

        public virtual void Clear()
        {
            items.Clear();
        }

        public virtual void AddItem(IFC_ClassEntity IFCBase)
        {

            List<IFC_Attribute?> parameters = IFCBase.GetDirectAttributes().Values.ToList();

            foreach (var parameter in parameters)
            {
                if(parameter!= null)
                {
                    CheckAndAddItem(parameter);
                }
            }

            if (IFCBase.Model == this)
            {
                return;
            }

            string IFC_ID = ""#"" + (items.Count + 1);
            IFCBase.IFC_ID = IFC_ID;
            items.Add(IFC_ID, IFCBase);
            IFCBase.Model = this;

        }

        /// <summary>
        /// Export model to IFC
        /// </summary>
        /// <returns></returns>
        public virtual void ExportIFC(string path)
        {
            var now = DateTime.UtcNow.ToString();
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(""ISO-10303-21;"");
                writer.WriteLine(""HEADER;"");
                writer.WriteLine(""FILE_DESCRIPTION("");
                writer.WriteLine(""/* description */ ('ViewDefinition [PresentationView]', 'Comment [Cutouts,SDS/2 Detailed model]'),"");
                writer.WriteLine(""/* implementation_level */ '2;1');"");
                writer.WriteLine(""FILE_NAME("");
                writer.WriteLine(""/* name */ '"" + path + ""',"");
                writer.WriteLine(""/* time_stamp */ '"" + now + ""',"");
                writer.WriteLine(""/* author */ ('Author Name'),"");
                writer.WriteLine(""/* organization */ ('Oganaization Name'),"");
                writer.WriteLine(""/* preprocessor_version */ 'Version Name',"");
                writer.WriteLine(""/* originating_system */ 'System Name',"");
                writer.WriteLine(""/* authorization */ 'None');"");
                writer.WriteLine(""FILE_SCHEMA (('"" + Version.ToString().ToUpper() + ""'));"");
                writer.WriteLine(""ENDSEC;"");
                writer.WriteLine(""DATA;"");
                writer.WriteLine("""");
                foreach (var item in items.Values.ToList())
                {
                    if (item != null)
                    {
                        string text = item.GetIFCFullText();
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("""");
                writer.WriteLine(""ENDSEC;"");
                writer.WriteLine(""END-ISO-10303-21;"");
            }
        }



        


        private void ReadDataline(string ifcText)
        {

            string[] leftright = ifcText.Split('=');
            if (leftright.Length < 2)
            {
                return;
            }
            string key = leftright[0].Replace("" "", """");

            string data = leftright[1];
            while (data.Length > 0 && data.Substring(0, 1) == "" "")
            {
                data = data.Substring(1);
            }
            int nameLenght = data.IndexOf('(');
            string name = data.Substring(0, nameLenght);
            string paraText = data.Substring(nameLenght + 1, data.Length - 3 - nameLenght);
            List<string> paramList = SplitParamText(paraText);


            var item = CreateItem(name);
            if (item != null)
            {
				if(item is IFC_Entity entity)
				{
                    entity.IFC_ID = key;
                    entity.AttributeTexts = paramList;
                    items.Add(key, entity);
                }
            }
        }

        private List<PropertyInfo> GetProperyList(string name)
        {
            List<PropertyInfo> propertyInfos = new List<PropertyInfo>();
            if (name == ""IFC_Entity"")
            {
                return propertyInfos;
            }
			if (name != null)
			{
                var objectType = Type.GetType(name);
				if (objectType != null)
				{
                    if (objectType.BaseType != null)
                    {
                        propertyInfos = GetProperyList(objectType.BaseType.Name);
                    }
                    propertyInfos.AddRange(objectType.GetProperties());
                }
                
            }
           
            return propertyInfos;
        }
        public void MapAandSetProperties(IFC_Entity item)
        {
            var textParameters = item.AttributeTexts;
            var itemType = item.GetType();
            var constructors = itemType.GetConstructors();
            int n;
            for (int i = 0; i < constructors.Length; i++)
            {
                var parameters = constructors[i].GetParameters();
                n = parameters.Length;
                if (n > 0)
                {
                    for (int j = 0; j < n; j++)
                    {
						if (parameters != null)
						{
                            var value = CreateAttribute(textParameters[j], parameters[j].ParameterType);
                            if (value is not null)
                            {
                                if (parameters != null)
                                {
                                    if (parameters[j] != null)
                                    {
                                        var name = parameters[j].Name;
                                        if (name != null)
                                        {
                                            var property = itemType.GetProperty(name);
                                            if (property != null)
                                            {
                                                property.SetValue(item, value);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                    break;
                }
            }
        }

        public List<string> SplitParamText(string paramText)
        {
            List<string> outputText = new List<string>();
            int bracketCount = 0;
            bool readingString = false;
            char[] chars = paramText.ToCharArray();
            int n = chars.Length;
            char c;
            string scanningText = """";
            for (int i = 0; i < n; i++)
            {
                c = chars[i];
                if (c == '\'')
                {
                    readingString = !readingString; // toggle 
                    scanningText += c;
                }
                else if (!readingString && c == '(')
                {
                    scanningText += c;
                    bracketCount++;
                }
                else if (!readingString && c == ')')
                {
                    bracketCount--;
                    scanningText += c;
                }
                else if (!readingString && c == ',' && bracketCount == 0)
                {

                }
                else
                {
                    scanningText += c;
                }

                if (i == n - 1 || (!readingString && c == ',' && bracketCount == 0))
                {
                    outputText.Add(scanningText);
                    scanningText = """";
                }
            }
            return outputText;
        }
 ";
                writer.Write(contain);

                WriteCSharpModelImport(nameSpaceName, writer);
                WriteCSharpModelGeneralCreate(nameSpaceName, writer);


                // Create item
                writer.WriteLine("\t\tprotected virtual IFC_Attribute? CreateItem(string className)");
                writer.WriteLine("\t\t{");
                writer.WriteLine("\t\t\tswitch (className)");
                writer.WriteLine("\t\t\t{");
                foreach (var basic in CSharpBasicDataTypes)
                {
                    writer.WriteLine("\t\t\t\tcase \"" + basic.Key + "\" : return new " + nameSpaceName + "." + basic.Key + "();");
                }
                writer.WriteLine("\t\t\t}");
                writer.WriteLine("\t\t\tswitch (Version)");
                writer.WriteLine("\t\t\t{");
                foreach (var version in Versions)
                {
                    writer.WriteLine("\t\t\t\tcase IFC_Version." + version + ":");

                    writer.WriteLine("\t\t\t\t\tswitch (className)");
                    writer.WriteLine("\t\t\t\t\t{");

                    foreach (var item in GetItems().Where(e => e.VersionName == version && e is IFCBasicType).ToList())
                    {
                        writer.WriteLine("\t\t\t\t\t\tcase \"" + item.Name.ToUpper() + "\" : return new " + nameSpaceName + "." + version + "." + item.Name + "();");
                    }
                    foreach (var item in EnumTypes.Where(e => e.VersionName == version).ToList())
                    {
                        writer.WriteLine("\t\t\t\t\t\tcase \"" + item.Name.ToUpper() + "\" : return new " + nameSpaceName + "." + version + "." + item.Name + "();");
                    }
                    foreach (var item in Entities.Where(e => e.VersionName == version && !e.IsAbstract).ToList())
                    {
                        writer.WriteLine("\t\t\t\t\t\tcase \"" + item.Name.ToUpper() + "\" : return new " + nameSpaceName + "." + version + "." + item.Name + "();");
                    }
                    writer.WriteLine("\t\t\t\t\t}");
                    writer.WriteLine("\t\t\t\tbreak;");
                }
                writer.WriteLine("\t\t\t}");
                writer.WriteLine("\t\t\treturn null;");
                writer.WriteLine("\t\t}");

                // Create list
                writer.WriteLine("\t\tprotected virtual IFC_Attribute? CreateList(string className)");
                writer.WriteLine("\t\t{");
                writer.WriteLine("\t\t\tswitch (className)");
                writer.WriteLine("\t\t\t{");
                foreach (var basic in CSharpBasicDataTypes)
                {
                    writer.WriteLine("\t\t\t\tcase \"" + basic.Key + "\": return new IFC_Attributes<" + nameSpaceName + "." + basic.Key + ">();");
                }
                writer.WriteLine("\t\t\t}");

                writer.WriteLine("\t\t\tswitch (Version)");
                writer.WriteLine("\t\t\t{");
                foreach (var version in Versions)
                {
                    writer.WriteLine("\t\t\t\tcase IFC_Version." + version + ":");
                    writer.WriteLine("\t\t\t\t\tswitch (className)");
                    writer.WriteLine("\t\t\t\t\t{");
                    foreach (var item in GetItems().Where(e => e.VersionName == version).ToList())
                    {
                        writer.WriteLine("\t\t\t\t\t\tcase \"" + item.Name.ToUpper() + "\": return new IFC_Attributes<" + nameSpaceName + "." + version + "." + item.Name + ">();");
                    }
                    writer.WriteLine("\t\t\t\t\t}");
                    writer.WriteLine("\t\t\t\tbreak;");
                }
                writer.WriteLine("\t\t\t}");
                writer.WriteLine("\t\t\treturn null;");
                writer.WriteLine("\t\t}");

                // Create listList
                writer.WriteLine("\t\tprotected virtual IFC_Attribute? CreateListList(string className)");
                writer.WriteLine("\t\t{");
                writer.WriteLine("\t\t\tswitch (className)");
                writer.WriteLine("\t\t\t{");
                foreach (var basic in CSharpBasicDataTypes)
                {
                    writer.WriteLine("\t\t\t\tcase \"" + basic.Key + "\":return new IFC_Attributes<IFC_Attributes<" + nameSpaceName + "." + basic.Key + ">>();");
                }
                writer.WriteLine("\t\t\t}");

                writer.WriteLine("\t\t\tswitch (Version)");
                writer.WriteLine("\t\t\t{");
                foreach (var version in Versions)
                {
                    writer.WriteLine("\t\t\t\tcase IFC_Version." + version + ":");
                    writer.WriteLine("\t\t\t\t\tswitch (className)");
                    writer.WriteLine("\t\t\t\t\t{");
                    foreach (var item in GetItems().Where(e => e.VersionName == version).ToList())
                    {
                        writer.WriteLine("\t\t\t\t\t\tcase \"" + item.Name.ToUpper() + "\" : return new IFC_Attributes<IFC_Attributes<" + nameSpaceName + "." + version + "." + item.Name + ">>();");
                    }
                    writer.WriteLine("\t\t\t\t\t}");
                    writer.WriteLine("\t\t\t\tbreak;");
                }
                writer.WriteLine("\t\t\t}");
                writer.WriteLine("\t\t\treturn null;");
                writer.WriteLine("\t\t}");

                // Create Bool
                WriteCSharpModelBasicCreate(nameSpaceName, writer, "CreateBool","bool");
                WriteCSharpModelBasicCreate(nameSpaceName, writer, "CreateString", "string");
                WriteCSharpModelBasicCreate(nameSpaceName, writer, "CreateInt", "int");
                WriteCSharpModelBasicCreate(nameSpaceName, writer, "CreateDouble", "double");
                WriteCSharpModelEnumCreate(nameSpaceName, writer);
                WriteCSharpModelNumericCreate(nameSpaceName, writer);
                writer.WriteLine("\t}");

                writer.WriteLine("\tpublic enum IFC_Version");
                writer.WriteLine("\t{");
                foreach (var version in Versions)
                {
                    writer.WriteLine("\t\t" + version + ",");
                }
                writer.WriteLine("\t\tUNDEFINED = 0");
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WriteCSharpModelConstructure(string nameSpaceName, StreamWriter writer)
        {
            string contain1 = @"
        /// <summary>
        /// Version of this model
        /// </summary>
        protected IFC_Version Version;

        /// <summary>
        /// IFC Items
        /// </summary>
		public Dictionary<string, IFC_Entity> items;

        /// <summary>
        /// Constructor
        /// </summary>
        public IFC_Model()
		{
			this.Version = IFC_Version.UNDEFINED;
            items = new Dictionary<string, IFC_Entity>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public IFC_Model(string version)
        {
            switch (version.ToUpper())
            {
";

            string contain2 = @"
            }
            items = new Dictionary<string, IFC_Entity>();
        }
";
            writer.WriteLine(contain1);

            string taps = "\t\t\t\t";
            foreach (var version in Versions)
            {
                writer.WriteLine(taps + "case \"" + version.ToUpper() + "\": this.Version = IFC_Version." + version + "; break;") ;
            }
            writer.WriteLine(contain2);
        }

        private void WriteCSharpModelImport(string nameSpaceName, StreamWriter writer)
        {
            string contain1 = @"
        public void ImportIFC(string path)
        {
            using (var reader = new StreamReader(path))
            {
				if (reader != null)
				{
					while (reader!= null && !reader.EndOfStream)
					{
						if (reader != null)
						{
							string? text = reader.ReadLine();
							if (text != null)
							{
								if (text.Contains(""FILE_SCHEMA""))
								{
									
";

            string contain2 = @"

								}
							}
						}
					}
				}
            }

            string[] allTexts;
            // read ifc file
            using (StreamReader reader = new StreamReader(path))
            {
                allTexts = reader.ReadToEnd().Split(""\r\n"");
                reader.Close();
            }
            bool readingData = false;
            string ifcText;
            int nLines = allTexts.Length;
            for (int i = 0; i < nLines; i++)
            {
                ifcText = allTexts[i];
                if (ifcText == ""DATA;"")
                {
                    readingData = true;
                    continue;
                }
                if (readingData)
                {
                    if (ifcText == """") continue;

                    if (ifcText.Length > 1 && ifcText.Replace("" "", """").Substring(0, 2) == ""/*"")
                    {
                        continue;
                    }
                    if (ifcText == ""ENDSEC;"") break;
                    ReadDataline(ifcText);
                }
            }

            var its = items.Values.ToList();

            foreach (var item in its)
            {
                if (item != null)
                {
                    item.Model = this;
                    MapAandSetProperties(item);
                }
            }
        }
";
            writer.WriteLine(contain1);

            string taps = "\t\t\t\t\t\t\t\t\t";
            foreach (var version in Versions)
            {
                writer.WriteLine(taps + "if (text.Contains(\"'" + version.ToUpper() + "'\"))");
                writer.WriteLine(taps + "{");
                writer.WriteLine(taps + "\tVersion = IFC_Version." + version + ";");
                writer.WriteLine(taps + "\tbreak;");
                writer.WriteLine(taps + "}");
            }
            writer.WriteLine(contain2);
        }

        private void WriteCSharpModelGeneralCreate(string nameSpaceName, StreamWriter writer)
        {
            string contain1 = @"
        protected IFC_Attribute? CreateAttribute(string input, Type type)
        {
            if (input.Length == 0)
            {
                return null;
            }
            if (input == ""*"")
            {
                return null;
            }
            if (input == ""$"")
            {
                return null;
            }

            if (input.Substring(0, 1) == "" "")
            {
                return CreateAttribute(input.Substring(1), type);
            }

            // string
            if (input.Substring(0, 1) == ""'"")
            {
                return CreateString(type.Name, input.Substring(1, input.Length - 2));
            }


			// entity
            if (input.Substring(0, 1) == ""#"")
            {
                if (items.TryGetValue(input, out var value))
                {
                    return value;
                }
                else
                {
                    return null;
                }

            }

            // int cast
            if (int.TryParse(input, out int intResult))
            {
                var result = CreateInt(type.Name, intResult);
                if (result is not null)
                {
                    return result;
                }
            }

            //float
            if (double.TryParse(input, out double floatResult))
            {
                var result = CreateDouble(type.Name, floatResult);
                if (result is not null)
                {
                    return result;
                }
            }

            //logical 
            if (input == "".T."")
            {
                return CreateBool(type.Name, true);

            }
            if (input == "".F."")
            {
                return CreateBool(type.Name, false);
            }
            if (input == "".U."")
            {
                return CreateBool(type.Name, false);
            }
            //enum
            if (input.Substring(0, 1) == ""."")
            {
                return CreateEnum(type.Name, input);
            }

            //List
            if (input.Substring(0, 1) == ""("")
            {
                dynamic? elements = null;
                var elementInput = SplitParamText(input.Substring(1, input.Length - 2));
                Type? elementType = null;
				if (type != null)
				{
                    var fullName = type.FullName;
                    if (type.Name == ""List`1"")
					{			
						if(fullName != null)
						{
                            var index1 = fullName.IndexOf(""["");
                            var index2 = fullName.IndexOf("","");
                            string elementTypeName = fullName.Substring(index1 + 2, index2 - index1 - 2);
                            elementType = Type.GetType(elementTypeName);
                            if (elementType == null)
                            {
                                var index3 = fullName.IndexOf(""]"");
                                string elementTypeName2 = fullName.Substring(index1 + 2, index3 - index1 - 0);
                                elementType = Type.GetType(elementTypeName2);
                                var index4 = elementTypeName.LastIndexOf(""[""); ;
                                elementTypeName = elementTypeName.Substring(index4 + 1);
                                elements = CreateListList(elementTypeName);
                            }
                            else
                            {
                                elements = CreateList(elementTypeName);
                            }
                        }
					}
					else
					{
						elements = CreateItem(type.Name);
						switch (Version)
						{";

            string contain2 =
                @" 
                   }
					}
                    foreach (var word in elementInput)
                    {
						if(elementType!= null)
						{
                            var elemment = CreateAttribute(word, elementType);
                            if (elements != null)
                            {
                                elements.Add(elemment);
                            }
                        }      
                    }
                    return elements;
                }
            }

            if (input.Contains(""(""))
            {
                int index1 = input.IndexOf(""("");
                int index2 = input.IndexOf("")"");
                string inputTypeName = input.Substring(0, index1);
                string parameter = input.Substring(index1 + 1, index2 - index1 - 1);
				if(inputTypeName!= null)
				{
					var item = CreateItem(inputTypeName);
					if(item!= null)
					{
                        Type? inputType = item.GetType();
                        if (inputType != null)
                        {
                            return CreateAttribute(parameter, inputType);
                        }
                    }
                }
            }
            return null;
        }
";

            writer.WriteLine(contain1);

            foreach (var version in Versions) 
            {
                writer.WriteLine("\t\t\t\t\t\t\tcase IFC_Version." + version + ":");
                writer.WriteLine("\t\t\t\t\t\t\tswitch (type.Name)");
                writer.WriteLine("\t\t\t\t\t\t\t{");

                foreach (var t in BasicTypeLists.Where(e=>e.VersionName == version))
                {
                    writer.WriteLine("\t\t\t\t\t\t\t\tcase \"" + t.Name + "\": elementType = Type.GetType(\"" + nameSpaceName + "." + (CSharpBasicDataTypes.ContainsKey(t.ParentName)? "": (version + ".")) + t.ParentName + "\"); break;");
                }
                writer.WriteLine("\t\t\t\t\t\t\t\tdefault: elementType = null; break;");
                writer.WriteLine("\t\t\t\t\t\t\t}");
                writer.WriteLine("\t\t\t\t\t\t\tbreak;");
            }
            writer.WriteLine(contain2);
        }

        private void WriteCSharpModelEnumCreate(string nameSpaceName, StreamWriter writer)
        {
            writer.WriteLine("\t\tprotected virtual IFC_Enum? CreateEnum(string className, string value)");
            writer.WriteLine("\t\t{");
            writer.WriteLine("\t\t\tswitch (Version)");
            writer.WriteLine("\t\t\t{");
            foreach (var version in Versions)
            {
                writer.WriteLine("\t\t\t\tcase IFC_Version." + version + ":");
                writer.WriteLine("\t\t\t\t\tswitch (className)");
                writer.WriteLine("\t\t\t\t\t{");
                foreach (var item in EnumTypes.Where(e => e.VersionName == version).ToList())
                {
                    writer.WriteLine("\t\t\t\t\t\tcase \"" + item.Name.ToUpper() + "\" : return (" + nameSpaceName + "." + version + "." + item.Name + ") value;");
                }
                writer.WriteLine("\t\t\t\t\t}");
                writer.WriteLine("\t\t\t\tbreak;");
            }
            writer.WriteLine("\t\t\t}");
            writer.WriteLine("\t\t\treturn null;");
            writer.WriteLine("\t\t}");
        }

        private void WriteCSharpModelBasicCreate(string nameSpaceName, StreamWriter writer,string methodName, string cSharpTypeName)
        {
            writer.WriteLine("\t\tprotected virtual IFC_Attribute? " + methodName +  "(string className, "+ cSharpTypeName + " value)");
            writer.WriteLine("\t\t{");
            writer.WriteLine("\t\t\tswitch (className)");
            writer.WriteLine("\t\t\t{");
            foreach (var basic in CSharpBasicDataTypes)
            {
                if (basic.Value == cSharpTypeName)
                {
                    writer.WriteLine("\t\t\t\tcase \"" + basic.Key + "\" : return (" + nameSpaceName + "." + basic.Key + ") value;");
                }
            }
            writer.WriteLine("\t\t\t}");
            writer.WriteLine("\t\t\tswitch (Version)");
            writer.WriteLine("\t\t\t{");
            foreach (var version in Versions)
            {
                writer.WriteLine("\t\t\t\tcase IFC_Version." + version + ":");
                writer.WriteLine("\t\t\t\t\tswitch (className)");
                writer.WriteLine("\t\t\t\t\t{");
                foreach (var item in GetItems().Where(e => e.VersionName == version && e is IFCBasicType).ToList())
                {
                    var basicItem = (IFCBasicType)item;
                    string cSharpType = basicItem.GetCSharpType();
                    if (cSharpType == cSharpTypeName)
                    {
                        writer.WriteLine("\t\t\t\t\t\tcase \"" + item.Name.ToUpper() + "\" : return (" + nameSpaceName + "." + version + "." + item.Name + ") value;");
                    }
                }
                writer.WriteLine("\t\t\t\t\t}");
                writer.WriteLine("\t\t\t\tbreak;");
            }
            writer.WriteLine("\t\t\t}");
            writer.WriteLine("\t\t\treturn null;");
            writer.WriteLine("\t\t}");
        }

        private void WriteCSharpModelNumericCreate(string nameSpaceName, StreamWriter writer)
        {
            writer.WriteLine("\t\tprotected virtual IFC_Attribute? CreateNumeric(string className, double value)");
            writer.WriteLine("\t\t{");
            writer.WriteLine("\t\t\tswitch (className)");
            writer.WriteLine("\t\t\t{");
            foreach (var basic in CSharpBasicDataTypes)
            {
                if (basic.Value == "double")
                {
                    writer.WriteLine("\t\t\t\tcase \"" + basic.Key + "\" : return (" + nameSpaceName + "." + basic.Key + ") value;");
                }
                if (basic.Value == "int")
                {
                    writer.WriteLine("\t\t\t\tcase \"" + basic.Key + "\" : return (" + nameSpaceName + "." + basic.Key + ") Math.Round(value);");
                }
            }
            writer.WriteLine("\t\t\t}");
            writer.WriteLine("\t\t\tswitch (Version)");
            writer.WriteLine("\t\t\t{");
            foreach (var version in Versions)
            {
                writer.WriteLine("\t\t\t\tcase IFC_Version." + version + ":");
                writer.WriteLine("\t\t\t\t\tswitch (className)");
                writer.WriteLine("\t\t\t\t\t{");
                foreach (var item in GetItems().Where(e => e.VersionName == version && e is IFCBasicType).ToList())
                {
                    var basicItem = (IFCBasicType)item;
                    string cSharpType = basicItem.GetCSharpType();
                    if (cSharpType == "double")
                    {
                        writer.WriteLine("\t\t\t\t\t\tcase \"" + item.Name.ToUpper() + "\" : return (" + nameSpaceName + "." + version + "." + item.Name + ") value;");
                    }
                    if (cSharpType == "int")
                    {
                        writer.WriteLine("\t\t\t\t\t\tcase \"" + item.Name.ToUpper() + "\" : return (" + nameSpaceName + "." + version + "." + item.Name + ") Math.Round(value);");
                    }
                }
                writer.WriteLine("\t\t\t\t\t}");
                writer.WriteLine("\t\t\t\tbreak;");
            }
            writer.WriteLine("\t\t\t}");
            writer.WriteLine("\t\t\treturn null;");
            writer.WriteLine("\t\t}");
        }

        private void WriteCSharpAttribute(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_Attribute.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic interface IFC_Attribute");
                writer.WriteLine("\t{");

                string contain =
       @"
        public string GetIFCText(bool includeClassName);
";
                writer.Write(contain);
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WriteCSharpClassEntity(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_ClassEntity.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic abstract class IFC_ClassEntity : IFC_Entity, IFC_Attribute");
                writer.WriteLine("\t{");

                string contain =
        @"
		/// <summary>
		/// Model that contains this.
		/// </summary>
        public IFC_Model? Model { get; set; }

		/// <summary>
		/// ID used in an IFC file.
		/// </summary>
		public string IFC_ID { get; set; }

	    /// <summary>
		/// Attribute Texts.
		/// </summary>
		public List<string> AttributeTexts { get; set; }

        /// <summary>
		/// Get All direct attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, IFC_Attribute?> GetDirectAttributes();

        /// <summary>
		/// Get derived attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, IFC_Attribute?> GetDerivedAttributes();

        /// <summary>
		/// Get inverse attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, IFC_Attribute?> GetInverseAttributes();

        /// <summary>
		/// Get inverse attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, bool> GetWhereAttributes();

        /// <summary>
		/// Constructor
		/// </summary>
        public IFC_ClassEntity()
		{
			IFC_ID = string.Empty;
            AttributeTexts = new List<string>();
        }

        public string GetIFCText(bool includeClassName)
        {
            return ""#"" + IFC_ID;
        }

        public string GetIFCFullText()
        {
            var parameters = GetDirectAttributes().Values.ToList();
            string str = IFC_ID + ""="" + GetType().Name.ToUpper() + ""("";   

            if (parameters != null)
            {
                if (GetType().Name == ""IFCPropertySingleValue"")
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        var parameter = parameters[i];
                        if(parameter!= null)
                        {
                            if (i == 2)
                            {
                                str += parameter.GetType().Name.ToUpper() + ""("" + GetParameterText(parameter) + "")"";
                            }
                            else
                            {
                                str += GetParameterText(parameter);
                            }
                            if (i < parameters.Count - 1)
                            {
                                str += "","";
                            }
                        }
                        else
                        {
                            str += GetParameterText(parameter);
                            if (i < parameters.Count - 1)
                            {
                                str += "","";
                            }
                        }
                    }
                }
                else if (GetType().Name == ""IFCPropertyEnumeration"")
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {

                        dynamic? parameter = parameters[i];
                        if (parameter != null)
                        {
                            if (i == 1)
                            {
                                var paramTexts = parameter.ToArray();
                                str += ""("";
                                for (int j = 0; j < paramTexts.Length; j++)
                                {
                                    str += ""IFCTEXT('"" + paramTexts[j] + ""')"";
                                    if (j < paramTexts.Length - 1)
                                    {
                                        str += "","";
                                    }
                                }
                                str += "")"";
                            }
                            else
                            {
                                str += GetParameterText(parameter);
                            }

                            if (i < parameters.Count - 1)
                            {
                                str += "","";
                            }
                        }
                        else
                        {
                            str += GetParameterText(parameter);
                            if (i < parameters.Count - 1)
                            {
                                str += "","";
                            }
                        }

                    }
                }
                else if (GetType().Name == ""IFCPropertyEnumeratedValue"")
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {

                        dynamic? parameter = parameters[i];
                        if (parameter != null)
                        {
                            if (i == 2)
                            {
                                var paramTexts = parameter.ToArray();
                                str += ""("";
                                for (int j = 0; j < paramTexts.Length; j++)
                                {
                                    str += ""IFCTEXT('"" + paramTexts[j] + ""')"";
                                    if (j < paramTexts.Length - 1)
                                    {
                                        str += "","";
                                    }
                                }
                                str += "")"";
                            }
                            else
                            {
                                str += GetParameterText(parameter);
                            }
                            if (i < parameters.Count - 1)
                            {
                                str += "","";
                            }
                        }
                        else
                        {
                            str += GetParameterText(parameter);
                            if (i < parameters.Count - 1)
                            {
                                str += "","";
                            }
                        }
                    }
                }


                else
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        var parameter = parameters[i];
                        if(parameter != null)
                        {
                            str += GetParameterText(parameter);
                            if (i < parameters.Count - 1)
                            {
                                str += "","";
                            }
                        }
                        else
                        {
                            str += GetParameterText(parameter);
                            if (i < parameters.Count - 1)
                            {
                                str += "","";
                            }
                        }
                    }
                }
                str += "");"";
            }
            return str;
        }


        private static string GetParameterText(dynamic? parameter)
        {

            string str = """";
            if (parameter == null)
            {
                str += ""$"";
            }
            else if (parameter is IFC_ClassEntity)
            {
                str += ((IFC_ClassEntity)parameter).IFC_ID;
            }
            else if (parameter.GetType().GetInterface(""IEnumerable"") != null)
            {
                str += ""("";
                for (int i = 0; i < parameter.Count; i++)
                {

                    str += GetParameterText(parameter[i]);
                    if (i < parameter.Count - 1)
                    {
                        str += "","";
                    }
                }
                str += "")"";
            }
            else
            {
                string typeName = parameter.GetType().Name;

                if (parameter is STRING)
                {
                    str += ""'"" + parameter.ToString() + ""'"";
                }
                else if (typeName.Contains(""Enum"")
                    || typeName == ""IFCBSplineCurveForm""
                    || typeName == ""IFCBSplineSurfaceForm""
                    || typeName == ""IFCKnotType""
                    || typeName == ""IFCPreferredSurfaceCurveRepresentation""
                    || typeName == ""IFCSIPrefix""
                    || typeName == ""IFCSIUnitName""
                    || typeName == ""IFCSurfaceSide""
                    || typeName == ""IFCTextPath""
                    || typeName == ""IFCTransitionCode""
                    || typeName == ""IFCTrimmingPreference"")
                {
                    str += """" + parameter + """";
                }
                else if (typeName == ""IFCBoolean"" || typeName == ""IFCLogical"" || typeName == ""BOOLEAN"")
                {
                    if ((bool)parameter)
                    {
                        str += "".T."";
                    }
                    else
                    {
                        str += "".F."";
                    }
                }
                else
                {
                    str += (float)parameter;
                }
            }
            return str;
        }

        public override string ToString()
        {
            return IFC_ID + "" : "" + GetType().Name;
        }
";
                writer.Write(contain);
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WriteCSharpEntity(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_Entity.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic interface IFC_Entity : IFC_Attribute");
                writer.WriteLine("\t{");

                string contain =
       @"
		public IFC_Model? Model { get; set; }
        public string IFC_ID { get; set; }
		public List<string> AttributeTexts { get; set; }
        public Dictionary<string, IFC_Attribute?> GetDirectAttributes();
        public Dictionary<string, IFC_Attribute?> GetDerivedAttributes();
        public Dictionary<string, IFC_Attribute?> GetInverseAttributes();
        public Dictionary<string, bool> GetWhereAttributes();
        public string GetIFCFullText();
";
                writer.Write(contain);
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WriteCSharpEnum(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_Enum.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic abstract class IFC_Enum : IFC_Attribute");
                writer.WriteLine("\t{");

                string contain =
       @"
                public string Value { get; set; } = """";
                public string GetIFCText(bool includeClassName)
                {
                    return ""."" + Value + ""."";
                }
";
                writer.Write(contain);
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WriteCSharpBasicType(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_SimpleData.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                foreach (var data in CSharpBasicDataTypes)
                {
                    string name = data.Key;
                    string cSharpText = data.Value;
                    writer.WriteLine("\tpublic class " + data.Key + ": IFC_Attribute");
                    writer.WriteLine("\t{");

                    if(name == "LOGICAL")
                    {
                        writer.WriteLine("\t\tpublic bool UNKNOWN {get; set;}");
                    }

                    writer.WriteLine("\t\tpublic " + cSharpText + " Value {get; set;}");
                    writer.WriteLine("\t\tpublic " + name + " () {Value = " + CSharpBasicDataDefaultValue[name] +  ";}");
                    writer.WriteLine("\t\tpublic " + name + " (" + cSharpText + " value) {Value = value;}");


                   


                    List<string> ImplicitTexts = GetImplicitText(name, cSharpText);
                    foreach(string ImplicitText in ImplicitTexts) { writer.WriteLine(ImplicitText); }

                    writer.WriteLine("\t\tpublic string GetIFCText(bool includeClassName)");
                    writer.WriteLine("\t\t{");
                    if (name == "STRING")
                    {
                        string contain = @"
			if (includeClassName)
			{
				return GetType().Name.ToUpper() + ""('"" + Value + ""')"";
			}
			else
			{
                return ""'"" + Value + ""'"";
            }
";
                        writer.Write(contain);
                    }
                    else if (name == "LOGICAL")
                    {
                        string contain = @"
			string text = """";
			if (UNKNOWN)
			{
				text = "".U."";
            }
			else if (Value)
			{
                text = "".T."";
            }
            else if (Value)
            {
                text = "".F."";
            }

            if (includeClassName)
            {
                return GetType().Name.ToUpper() + ""('"" + text + ""')"";
            }
            else
            {
                return ""'"" + text + ""'"";
            }
";
                        writer.Write(contain);
                    }

                    else if (name == "BOOLEAN")
                    {
                        string contain = @"
			string text = """";
			if (Value)
			{
                text = "".T."";
            }
            else if (Value)
            {
                text = "".F."";
            }

            if (includeClassName)
            {
                return GetType().Name.ToUpper() + ""('"" + text + ""')"";
            }
            else
            {
                return ""'"" + text + ""'"";
            }
";
                        writer.Write(contain);
                    }
                    else
                    {
                        string contain = @"
			if (includeClassName)
			{
				return GetType().Name.ToUpper() + ""("" + Value + "")"";
			}
			else
			{
                return  Value + """";
            }
";
                        writer.Write(contain);
                    }

                    writer.WriteLine("\t\t}");

                    

                    writer.WriteLine("\t}");
                }
                writer.WriteLine("}");
            }
        }

        private void WtiteCSharpAttributes(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_Attributes.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("using System.Linq;");
                writer.WriteLine("using System.Text;");
                writer.WriteLine("using System.Threading.Tasks;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic class IFC_Attributes<T> : List<T>, IFC_Attribute where T: IFC_Attribute ");
                writer.WriteLine("\t{");
                string contain =
   @"
		public IFC_Attributes() : base() { }
        public IFC_Attributes(List<T>? value)
        {
            if (value != null)
            {
                foreach (var v in value)
                {
                    Add(v);
                }
            }
        }
        public IFC_Attributes(IFC_Attributes<T>? value)
        {
            if (value != null)
            {
                foreach (var v in value)
                {
                    Add(v);
                }
            }
        }
        public string GetIFCText(bool includeClassName)
        {
            string texts = ""("";
            int n = Count;
            for(int i = 0; i < n; i++)
            {
                texts += this[i].GetIFCText(includeClassName);
                if(i < n - 1)
                {
                    texts += "", "";
                }
            }
            texts += "")"";
            return texts;
        }
";
                writer.Write(contain);
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }
        /// <summary>
        /// Add implicit text
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cSharpText"></param>
        /// <returns></returns>
        public List<string> GetImplicitText(string name, string cSharpText)
        {
            return new List<string>
            {
             
                "\t\tpublic static implicit operator " + name + "(" + cSharpText + " value) { return new " + name + "(value);}",
                "\t\tpublic static implicit operator " + cSharpText + "(" + name + " value) { return value.Value;}"
            };
            
        }

    }
}
