using Microsoft.SqlServer.Management.XEvent;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
                var entityAttributes = entity.AllAttributes.Where(e => e is IFCDeriveAttribute || e is IFCInverseAttribute).ToList();
                if(entity.Name == "IfcAxis2Placement2D")
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
                foreach (var attribute in entity.DeriveAttributes)
                {
                    
                    foreach(var parent in parents)
                    {
                        if(parent.DeriveAttributes.Where(x=>x.Name == attribute.Name).Count() >0)
                        {
                            attribute.isOverride = true;
                        }
                        if (parent.ParameterAttributes.Where(x => x.Name == attribute.Name).Count() > 0)
                        {
                            attribute.isOverride = true;
                        }
                        if (parent.AdditionalSelectAttibutes.Where(x => x.Name == attribute.Name).Count() > 0)
                        {
                            attribute.isOverride = true;
                        }
                    }
                }
                foreach (var attribute in entity.ParameterAttributes)
                {

                    foreach (var parent in parents)
                    {
                        if (parent.AdditionalSelectAttibutes.Where(x => x.Name == attribute.Name).Count() > 0)
                        {
                            attribute.isOverride = true;
                        }
                    }
                }
                foreach (var attribute in entity.InverseAttributes)
                {
                    var relatingEntity = Entities.Where(x => x.Name == attribute.TypeName && x.VersionName == entity.VersionName).ToList()[0];
                    var parameterAttributes = relatingEntity.ParameterAttributes;
                    foreach(var param in parameterAttributes)
                    {
                        if(param.Name == attribute.RelatedAttributeName)
                        {
                            attribute.RelatedAttribute = param;
                        }
                    }
                    if(attribute.RelatedAttribute == null)
                    {

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
            items.AddRange(Functions);
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
            WtiteCSharpModel(folderDir, nameSpaceName);
            WtiteCSharpEntity(folderDir, nameSpaceName);
            WtiteCSharpBasicType(folderDir, nameSpaceName);
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
            using (StreamWriter writer = new StreamWriter(folderDir + version + ".cs"))
            {
                var items = GetItems(version);
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName + "." + version);
                writer.WriteLine("{");
                foreach (var item in items)
                {
                    var texts = item.GetCSharpTexts();
                    foreach (var text in texts)
                    {
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("}");
            }
        }

        private void WtiteCSharpModel(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "Ifc_Model.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic class Ifc_Model");
                writer.WriteLine("\t{");
        
                string contain =
        @"
               /// <summary>
        /// Version of this model
        /// </summary>
        protected Ifc_Version Version;

        /// <summary>
        /// IFC Items
        /// </summary>
		public Dictionary<string, Ifc_Entity> items;

        /// <summary>
        /// Constructure
        /// </summary>
        public Ifc_Model(string version)
        {
            switch (version.ToUpper())
            {
                case ""IFC2X3"": this.Version = Ifc_Version.Ifc2x3; break;
                case ""IFC4"": this.Version = Ifc_Version.Ifc4; break;
                case ""IFC4X1"": this.Version = Ifc_Version.Ifc4x1; break;
                case ""IFC4X2"": this.Version = Ifc_Version.Ifc4x2; break;
                case ""IFC4X3"": this.Version = Ifc_Version.Ifc4x3; break;
            }
            items = new Dictionary<string, Ifc_Entity>();
        }

        /// <summary>
        /// Initalize the model
        /// </summary>
        public virtual void Initialize()
        {
            items = new Dictionary<string, Ifc_Entity>();
        }

        /// <summary>
        /// Return IFC Item with specificed type
        /// </summary>
        /// <typeparam name=""T""></typeparam>
        /// <returns></returns>
        public List<T> GetItems<T>() where T : Ifc_Entity
		{
			List<Ifc_Entity> itemList = items.Values.Where(x => x is T).ToList();
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
                if (parameter is Ifc_Entity entity)
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

        public virtual void AddItem(Ifc_Entity ifcBase)
        {

            List<object?> parameters = ifcBase.GetParameters();

            foreach (var parameter in parameters)
            {
                if(parameter!= null)
                {
                    CheckAndAddItem(parameter);
                }
            }

            if (ifcBase.Model == this)
            {
                return;
            }

            string ifcid = ""#"" + (items.Count + 1);
            ifcBase.ifcid = ifcid;
            items.Add(ifcid, ifcBase);
            ifcBase.Model = this;

        }

        /// <summary>
        /// Export model to Ifc
        /// </summary>
        /// <returns></returns>
        public virtual void ExportIfc(string path)
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
                writer.WriteLine(""FILE_SCHEMA (('"" + GetVersionText().ToUpper() + ""'));"");
                writer.WriteLine(""ENDSEC;"");
                writer.WriteLine(""DATA;"");
                writer.WriteLine("""");
                foreach (var item in items.Values.ToList())
                {
                    if (item != null)
                    {
                        string text = item.GetIfcFullText();
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("""");
                writer.WriteLine(""ENDSEC;"");
                writer.WriteLine(""END-ISO-10303-21;"");
            }
        }

        /// <summary>
        /// Get Version text of this version
        /// </summary>
        /// <returns></returns>
        public string GetVersionText()
        {
            switch (Version)
            {
                case Ifc_Version.UNDEFINED: return """";
                case Ifc_Version.Ifc2x3: return ""Ifc2x3"";
                case Ifc_Version.Ifc4: return ""Ifc4"";
                case Ifc_Version.Ifc4x1: return ""Ifc4x1"";
                case Ifc_Version.Ifc4x2: return ""Ifc4x2"";
                case Ifc_Version.Ifc4x3: return ""Ifc4x3"";
            }
            return """";
        }
 ";
                writer.Write(contain);

                writer.WriteLine("\t}");

                writer.WriteLine("\tpublic enum Ifc_Version");
                writer.WriteLine("\t{");
                writer.WriteLine("\t\tUNDEFINED = 0,");
                writer.WriteLine("\t\tIfc2x3 = 23,");
                writer.WriteLine("\t\tIfc4 = 4,");
                writer.WriteLine("\t\tIfc4x1 = 41,");
                writer.WriteLine("\t\tIfc4x2 = 42,");
                writer.WriteLine("\t\tIfc4x3 = 43,");
                writer.WriteLine("\t}");

                writer.WriteLine("}");
            }
        }

        private void WtiteCSharpEntity(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "Ifc_Entity.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic abstract class Ifc_Entity");
                writer.WriteLine("\t{");

                string contain =
       @"
		/// <summary>
		/// Model that contains this.
		/// </summary>
        public Ifc_Model? Model;

		/// <summary>
		/// ID used in an IFC file.
		/// </summary>
		public string ifcid;

        /// <summary>
		/// Get All Parameters
		/// </summary>
		/// <returns></returns>
        public abstract List<object?> GetParameters();

        /// <summary>
		/// Constructor
		/// </summary>
        public Ifc_Entity()
		{
			ifcid = string.Empty;
        }

        public string GetIfcFullText()
        {
            var parameters = GetParameters();
            string str = ifcid + ""="" + GetType().Name.ToUpper() + ""("";   

            if (parameters != null)
            {
                if (GetType().Name == ""IfcPropertySingleValue"")
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
                else if (GetType().Name == ""IfcPropertyEnumeration"")
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
                else if (GetType().Name == ""IfcPropertyEnumeratedValue"")
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
            else if (parameter is Ifc_Entity)
            {
                str += ((Ifc_Entity)parameter).ifcid;
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
                    || typeName == ""IfcBSplineCurveForm""
                    || typeName == ""IfcBSplineSurfaceForm""
                    || typeName == ""IfcKnotType""
                    || typeName == ""IfcPreferredSurfaceCurveRepresentation""
                    || typeName == ""IfcSIPrefix""
                    || typeName == ""IfcSIUnitName""
                    || typeName == ""IfcSurfaceSide""
                    || typeName == ""IfcTextPath""
                    || typeName == ""IfcTransitionCode""
                    || typeName == ""IfcTrimmingPreference"")
                {
                    str += """" + parameter + """";
                }
                else if (typeName == ""IfcBoolean"" || typeName == ""IfcLogical"" || typeName == ""BOOLEAN"")
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
            return ifcid + "" : "" + GetType().Name;
        }
";
                writer.Write(contain);



                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WtiteCSharpBasicType(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "Basic.cs"))
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
                    writer.WriteLine("\tpublic class " + data.Key);
                    writer.WriteLine("\t{");
                    writer.WriteLine("\t\tpublic " + cSharpText + " Value {get; set;}");
                    writer.WriteLine("\t\tpublic " + name + " () {Value = " + CSharpBasicDataDefaultValue[name] +  ";}");
                    writer.WriteLine("\t\tpublic " + name + " (" + cSharpText + " value) {Value = value;}");
                    List<string> ImplicitTexts = GetImplicitText(name, cSharpText);
                    foreach(string ImplicitText in ImplicitTexts) { writer.WriteLine(ImplicitText); }
                    writer.WriteLine("\t}");
                }
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
