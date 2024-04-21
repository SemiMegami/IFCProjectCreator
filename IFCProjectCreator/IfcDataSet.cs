using Microsoft.SqlServer.Management.XEvent;
using Newtonsoft.Json.Bson;
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
        public readonly string GLOBALName = "GLOBAL";
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
        public List<IFCSimpleType> BasicTypes { get; private set; }
        public List<IFCSimpleTypeList> BasicTypeLists { get; private set; }
        public List<IFCEnumType> EnumTypes { get; private set; }
        public List<IFCSelectType> SelectTypes { get; private set; }
        public List<IFCEntity> Entities { get; private set; }
        public List<IFCFunction> Functions { get; private set; }
        public List<string> Versions { get; private set; }

        public Dictionary<string, List<string>> ManualItems ;
        public List<IFCSelectType> GLOBALSelectTypes { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public IFCDataSet()
        {
            BasicTypes = new List<IFCSimpleType>();
            BasicTypeLists = new List<IFCSimpleTypeList>();
            EnumTypes = new List<IFCEnumType> ();
            SelectTypes = new List<IFCSelectType>();
            Entities = new List<IFCEntity>();
            Functions = new List<IFCFunction>();
            Versions = new List<string> ();
            GLOBALSelectTypes = new List<IFCSelectType> ();
            ManualItems = new Dictionary<string, List<string>>();
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
            SetAttribute();
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
                                            item = new IFCSimpleTypeList(this, version);
                                            BasicTypeLists.Add((IFCSimpleTypeList)item);
                                        }
                                        else
                                        {
                                            item = new IFCSimpleType(this, version);
                                            BasicTypes.Add((IFCSimpleType)item);
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

        public void ReadManualItem(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    if (reader != null)
                    {
                        string line;
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine() ?? "";
                            if (line.Contains("//MANUAL_"))
                            {
                                var key = line.Trim();
                                List<string> contains = new List<string>();
                                while (!line.Contains("//END_MANUAL"))
                                {
                                  
                                    line = reader.ReadLine() ?? "";
                                    if (!line.Contains("//END_MANUAL"))
                                    {
                                        contains.Add(line);
                                    } 
                                }
                                ManualItems.Add(key, contains);
                            }
                        }
                    }
                }
            }
            
        }

            /// <summary>
            /// Link parents
            /// </summary>
            private void SetParent()
        {
            List<IFCClass> Items = GetItems();

            foreach (var selectType in SelectTypes)
            {
                foreach (var subClassName in selectType.SubClassesNames)
                {
                    IFCClass subClass = Items.First(e => e.Name == subClassName && e.VersionName == selectType.VersionName);
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
                List<IFCSimpleType> parents = BasicTypes.Where(e => e.Name == basicType.ParentName && e.VersionName == basicType.VersionName).ToList();
                if (parents.Count > 0)
                {
                    IFCSimpleType parent = parents.First();
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
                if (allSubClasses.Where(e => e is IFCSimpleType || e is IFCSimpleTypeList).Count() > 0)
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

                                if (attribute0.TypeName != attribute.TypeName || attribute0.Aggregation != attribute.Aggregation || attribute0.ListType != attribute.ListType)
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
                                    ListType = attribute.ListType,
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
                            ListType = attribute.ListType,
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
                            ListType = attribute.ListType,
                            isClassAttribute = true,
                        });
                    }
                }
            }
        }

        public void SetGLOBAL()
        {
            Dictionary<string, IFCSelectType> GLOBALTypes = new Dictionary<string, IFCSelectType> ();
            List<IFCClass> Items = GetItems();

            foreach (var item in Items)
            {
                if (!GLOBALTypes.ContainsKey(item.Name))
                {
                    IFCSelectType newType = new IFCSelectType(this, GLOBALName) 
                    { 
                        Name = item.Name,
                        IsGLOBAL = true,
                    };
                    GLOBALTypes.Add(item.Name, newType);
                }
                IFCSelectType GLOBAL = GLOBALTypes[item.Name];


            }
            GLOBALSelectTypes = GLOBALTypes.Values.ToList();

            foreach (var GLOBALSelectType in GLOBALSelectTypes)
            {
                List < IFCClass > typeItems = Items.Where(e => e.Name == GLOBALSelectType.Name).ToList();
                if (typeItems.Count > 0)
                {
                    if (typeItems[0] is IFCSimpleTypeList basicTypeList)
                    {
                        string cSharpType = basicTypeList.GetCSharpType();
                        if (cSharpType.Length > 0)
                        {
                            GLOBALSelectType.SelectAttributes.Add(new IFCSelectAttribute() { Name = "Value", TypeName = basicTypeList.GetCSharpType() });
                        }
                    }

                    else if (typeItems[0] is IFCSimpleType basicType)
                    {
                        string cSharpType = basicType.GetCSharpType();
                        bool found = false;
                        foreach (var item in typeItems)
                        {
                            if (item is IFCSimpleType basicType1)
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
                            GLOBALSelectType.SelectAttributes.Add(new IFCSelectAttribute() { Name = "Value", TypeName = cSharpType });
                        }
                    }

                    else if (typeItems[0] is IFCEnumType enumType)
                    {
                        List<IFCEnumType> enumItems = new List<IFCEnumType>();
                        bool found = false;
                        List<string> values = new List<string>();
                        foreach (var typeItem in typeItems)
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
                                    GLOBALSelectType.SelectAttributes.Add(new IFCSelectAttribute() { Name = enumValue, TypeName = "static string" });
                                }
                            }

                            GLOBALSelectType.SelectAttributes.Add(new IFCSelectAttribute() { Name = "Value", TypeName = "string" });
                        }
                    }
                    else if (typeItems[0] is IFCSelectType selectType)
                    {
                        List<IFCSelectType> selectItems = new List<IFCSelectType>();
                        bool found = false;
                        bool isReadOnly = false;
                        foreach (var typeItem in typeItems)
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
                                            compareItem.includedInGLOBAL = true;
                                            if (compareItem.isReadOnly)
                                            {
                                                isReadOnly = true;
                                            }
                                        }
                                    }
                                    GLOBALSelectType.SelectAttributes.Add(new IFCSelectAttribute()
                                    {
                                        Name = "_" + attribute.Name,
                                        TypeName = attribute.TypeName,
                                        Aggregation = attribute.Aggregation,
                                        ListType = attribute.ListType,
                                        Dataset = this,
                                        isReadOnly = isReadOnly
                                    });
                                }
                            }
                        }
                    }

                    else if (typeItems[0] is IFCEntity entity)
                    {
                        GLOBALSelectType.IsEntity = true;
                        List<IFCEntity> entities = new List<IFCEntity>();
                        bool found = false;
                        bool isReadOnly = false;
                        foreach (var typeItem in typeItems)
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
                                            compareItem.includedInGLOBAL = true;
                                            if (compareItem.isReadOnly)
                                            {
                                                isReadOnly = true;
                                            }
                                        }
                                    }
                                    GLOBALSelectType.SelectAttributes.Add(new IFCSelectAttribute()
                                    {
                                        Name = "_" + attribute.Name,
                                        TypeName = attribute.TypeName,
                                        Aggregation = attribute.Aggregation,
                                        Dataset = this,
                                        ListType = attribute.ListType,
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
        /// Link attribute 
        /// </summary>
        private void SetAttribute()
        {
            
            foreach (var entity in Entities)
            {
                var selectDatas = SelectTypes.Where(e => e.VersionName == entity.VersionName).ToList();
                var entityDatas = Entities.Where(e => e.VersionName == entity.VersionName).ToList();
                var basicDatas = BasicTypes.Where(e => e.VersionName == entity.VersionName).ToList();
                var basicListDatas = BasicTypeLists.Where(e => e.VersionName == entity.VersionName).ToList();
                var enumDatas = EnumTypes.Where(e => e.VersionName == entity.VersionName).ToList();


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
                    if(basicListDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null){
                        attribute.AttributeType = IFCAttributeType.SIMPLELIST;
                    }
                    if (entityDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null){
                        attribute.AttributeType = IFCAttributeType.ENTITY;
                    }
                    if (basicDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null){
                        attribute.AttributeType = IFCAttributeType.SIMPLE;
                    }
                    if (CSharpBasicDataTypes.ContainsKey(attribute.TypeName))
                    {
                        attribute.AttributeType = IFCAttributeType.SIMPLE;
                    }
                    if (enumDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null){
                        attribute.AttributeType = IFCAttributeType.ENUM;
                    }
                    if (selectDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null){
                        attribute.AttributeType = IFCAttributeType.SELECT;
                    }

                    var setDerive = entity.DerivedAttributes.FirstOrDefault(e => e.Name == attribute.Name);
                    if (setDerive != null)
                    {
                        setDerive.includeSet = true;
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
            List<IFCClass> Items = new List<IFCClass>();
            Items.AddRange(BasicTypes);
            Items.AddRange(BasicTypeLists);
            Items.AddRange(EnumTypes);
            Items.AddRange(SelectTypes);
            Items.AddRange(Entities);
            return Items;
        }

        /// <summary>
        /// Get Item for Specific version
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<IFCClass> GetItems(string version) { 

            if(version == GLOBALName)
            {
                List<IFCClass> classes = new List<IFCClass>();
                foreach (var g in GLOBALSelectTypes)
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


        public List<string> GetNonAbstractSubClass(string className)
        {
            List<string> names = new List<string>();
            var selectTypes = SelectTypes.Where(x => x.Name == className);
            foreach (var item in selectTypes)
            {
                var subclasses = item.AllNonAbstractSubclasses;
                foreach (var subclass in subclasses)
                {
                    if (!names.Contains(subclass.Name))
                    {
                        names.Add(subclass.Name);
                    }
                }
            }

            var entities = Entities.Where(x => x.Name == className);
            foreach (var item in entities)
            {
                var subclasses = item.AllNonAbstractSubclasses;
                foreach (var subclass in subclasses)
                {
                    if (!names.Contains(subclass.Name))
                    {
                        names.Add(subclass.Name);
                    }
                }
            }
            names.Sort();
            return names;
        }

        #region Write CSharp

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
            WriteCSharp(folderDir, nameSpaceName, GLOBALName);
            WriteCSharpLog(folderDir, nameSpaceName);
            WriteCSharpTest(folderDir, nameSpaceName);
        }

        /// <summary>
        /// Write C# classes file in specificed folder
        /// </summary>
        /// <param name="folderDir"></param>
        public void WriteCSharp(string folderDir, string nameSpaceName, string version)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + (version == GLOBALName?"IFC_":"") + version + ".cs"))
            {
                var Items = GetItems(version);
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("#nullable enable");
                writer.WriteLine("namespace " + nameSpaceName + "." + version);
                writer.WriteLine("{");


                writer.WriteLine("\t#region ---- SIMPLE DATA TYPES ----");
                foreach (var item in Items.Where(e=>e is IFCSimpleType || e is IFCSimpleTypeList).ToList())
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
                foreach (var item in Items.Where(e => e is IFCEnumType).ToList())
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
                foreach (var item in Items.Where(e => e is IFCSelectType).ToList())
                {
                    var texts = item.GetCSharpTexts();
                    foreach (var text in texts)
                    {
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("\t#endregion");
                writer.WriteLine("");
                writer.WriteLine("\t#region ---- ENTITIES ----");
                foreach (var item in Items.Where(e => e is IFCEntity).ToList())
                {
                    var texts = item.GetCSharpTexts();
                    foreach (var text in texts)
                    {
                        writer.WriteLine(text);
                    }
                }
                writer.WriteLine("\t#endregion");

                if(version!= GLOBALName)
                {
                    writer.WriteLine("");
                    writer.WriteLine("\t#region ---- BASE ENTITY ----");
                    writer.WriteLine("\tpublic abstract class " + version.ToUpper() + "_Entity : IFC_ENTITY");
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
                  
                }
                writer.WriteLine("}");

            }
        }

        private void WriteCSharpModel(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_MODEL.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("using System.Linq;");
                writer.WriteLine("using System.Text;");
                writer.WriteLine("using System.Threading.Tasks;");
                writer.WriteLine("using System.IO;");
                writer.WriteLine("using System.Reflection;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("#nullable enable");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic class IFC_MODEL");
                writer.WriteLine("\t{");


                WriteCSharpModelConstructure(nameSpaceName, writer);


                string contain =
        @"
        /// <summary>
        /// Return IFC Item with specified type
        /// </summary>
        /// <typeparam name=""T""></typeparam>
        /// <returns></returns>
        public List<T> GetItems<T>() where T : IFC_I_ENTITY
		{
			List<IFC_I_ENTITY> itemList = Items.Values.Where(x => x is T).ToList();
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
                if (parameter is IFC_ENTITY entity)
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
            Items.Clear();
        }

        public virtual void AddItem(IFC_ENTITY IFCBase)
        {

            List<IFC_BASE?> parameters = IFCBase.GetDirectAttributes().Values.ToList();

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

            string IFC_ID = ""#"" + (Items.Count + 1);
            IFCBase.IFC_ID = IFC_ID;
            Items.Add(IFC_ID, IFCBase);
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
                writer.WriteLine(""/* organization */ ('Organization Name'),"");
                writer.WriteLine(""/* preprocessor_version */ 'Version Name',"");
                writer.WriteLine(""/* originating_system */ 'System Name',"");
                writer.WriteLine(""/* authorization */ 'None');"");
                writer.WriteLine(""FILE_SCHEMA (('"" + Version.ToString().ToUpper() + ""'));"");
                writer.WriteLine(""ENDSEC;"");
                writer.WriteLine(""DATA;"");
                writer.WriteLine("""");
                foreach (var item in Items.Values.ToList())
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

            string[] leftRight = ifcText.Split('=');
            if (leftRight.Length < 2)
            {
                return;
            }
            string key = leftRight[0].Replace("" "", """");

            string data = leftRight[1];
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
				if(item is IFC_I_ENTITY entity)
				{
                    entity.IFC_ID = key;
                    entity.AttributeTexts = paramList;
                    Items.Add(key, entity);
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

                // Create item
                writer.WriteLine("\t\tprotected virtual IFC_BASE? CreateItem(string className)");
                writer.WriteLine("\t\t{");
                writer.WriteLine("\t\t\tswitch (className)");
                writer.WriteLine("\t\t\t{");
                foreach (var basic in CSharpBasicDataTypes)
                {
                    writer.WriteLine("\t\t\t\tcase \"" + basic.Key + "\" : return new " + nameSpaceName + ".IFC_" + basic.Key + "();");
                }
                writer.WriteLine("\t\t\t}");
                writer.WriteLine("\t\t\tswitch (Version)");
                writer.WriteLine("\t\t\t{");
                foreach (var version in Versions)
                {
                    writer.WriteLine("\t\t\t\tcase IFC_VERSION." + version + ":");

                    writer.WriteLine("\t\t\t\t\tswitch (className)");
                    writer.WriteLine("\t\t\t\t\t{");

                    foreach (var item in GetItems().Where(e => e.VersionName == version && e is IFCSimpleType).ToList())
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

               
         
                //WriteCSharpModelBasicCreate(nameSpaceName, writer, "CreateBool","bool");
                //WriteCSharpModelBasicCreate(nameSpaceName, writer, "CreateString", "string");
                //WriteCSharpModelBasicCreate(nameSpaceName, writer, "CreateInt", "int");
                //WriteCSharpModelBasicCreate(nameSpaceName, writer, "CreateDouble", "double");
                //WriteCSharpModelEnumCreate(nameSpaceName, writer);
                //WriteCSharpModelNumericCreate(nameSpaceName, writer);
                writer.WriteLine("\t}");

                writer.WriteLine("\tpublic enum IFC_VERSION");
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
        protected IFC_VERSION Version;

        /// <summary>
        /// IFC Items
        /// </summary>
		public Dictionary<string, IFC_I_ENTITY> Items;

        /// <summary>
		/// Error Log generated during importing.
		/// </summary>
		public List<IFC_LOG> Logs { get; set; }



        /// <summary>
        /// Constructor
        /// </summary>
        public IFC_MODEL()
		{
			this.Version = IFC_VERSION.UNDEFINED;
            Items = new Dictionary<string, IFC_I_ENTITY>();
            Logs = new List<IFC_LOG>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public IFC_MODEL(string version) : this()
        {
            switch (version.ToUpper())
            {
";

            string contain2 = @"
            }
        }
";
            writer.WriteLine(contain1);

            string taps = "\t\t\t\t";
            foreach (var version in Versions)
            {
                writer.WriteLine(taps + "case \"" + version.ToUpper() + "\": this.Version = IFC_VERSION." + version + "; break;") ;
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

            var its = Items.Values.ToList();

            foreach (var item in its)
            {
                if (item != null)
                {
                    item.Model = this;
                }
            }
            foreach (var item in its)
            {
                if (item != null)
                {
                    item.SetByAttributeTexts();
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
                writer.WriteLine(taps + "\tVersion = IFC_VERSION." + version + ";");
                writer.WriteLine(taps + "\tbreak;");
                writer.WriteLine(taps + "}");
            }
            writer.WriteLine(contain2);
        }

        private void WriteCSharpLog(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_LOG.cs"))
            {

                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("using System.Linq;");
                writer.WriteLine("using System.Text;");
                writer.WriteLine("using System.Threading.Tasks;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("#nullable enable");
                writer.WriteLine("namespace " + nameSpaceName);


                string contain = 
@"          
{
    public class IFC_LOG
    {
        IFC_LOGTYPE LogType;
        public IFC_I_ENTITY? Source;
        public string Information;

        public IFC_LOG(IFC_LOGTYPE logType, IFC_I_ENTITY source, string Information) 
        { 
            this.LogType = logType;
            this.Source = source;
            this.Information = Information;
        }
        public IFC_LOG(IFC_LOGTYPE logType, string Information)
        {
            this.LogType = logType;
            this.Information = Information;
        }

        public override string ToString()
        {
            if(Source != null)
            {
                return LogType.ToString()+  "": "" + Source.IFC_ID + ""-"" + Source.GetType().Name.ToUpper() + "": "" + Information;
            }
            else
            {
                return LogType.ToString() + "": "" + Information;
            }
        }
    }

    public enum IFC_LOGTYPE
    {
        ERROR,
        WARNING, 
        INFO
    }
}

";
                writer.Write(contain);
            }
        }
        private void WriteCSharpAttribute(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_BASE.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("#nullable enable");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic interface IFC_BASE");
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
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_ENTITY.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("#nullable enable");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic abstract class IFC_ENTITY : IFC_I_ENTITY, IFC_BASE");
                writer.WriteLine("\t{");

                string contain =
        @"
		/// <summary>
		/// Model that contains this.
		/// </summary>
        public IFC_MODEL? Model { get; set; }

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
        public abstract Dictionary<string, IFC_BASE?> GetDirectAttributes();

        /// <summary>
		/// Get derived attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, IFC_BASE?> GetDerivedAttributes();

        /// <summary>
		/// Get inverse attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, IFC_BASE?> GetInverseAttributes();

        /// <summary>
		/// Get inverse attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, bool> GetWhereAttributes();

        /// <summary>
		/// Constructor
		/// </summary>
        public IFC_ENTITY()
		{
			IFC_ID = string.Empty;
            AttributeTexts = new List<string>();
        }
        /// <summary>
		/// Set all attributes by current ""AttributeTexts""
		/// </summary>
        public virtual void SetByAttributeTexts()
        {
        }

        public string GetIFCText(bool includeClassName)
        {
            return ""#"" + IFC_ID;
        }

        public abstract string GetIFCFullText();

        public override string ToString()
        {
            return IFC_ID + "" : "" + GetType().Name;
        }

        protected List<string>? SplitList(string input)
		{
            int index1 = input.IndexOf(""("");
            int index2 = input.LastIndexOf("")"");
			if(index1 > -1 && index2 > -1)
			{
                string inputTypeName = input.Substring(0, index1);
                string trim = input.Substring(index1 + 1, index2 - index1 - 1);

                List<string> outputText = new List<string>();
                int bracketCount = 0;
                bool readingString = false;
                char[] chars = trim.ToCharArray();
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
            return null;
        }
";
                writer.Write(contain);
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WriteCSharpEntity(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_I_ENTITY.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("#nullable enable");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic interface IFC_I_ENTITY : IFC_BASE");
                writer.WriteLine("\t{");

                string contain =
       @"
		public IFC_MODEL? Model { get; set; }
        public string IFC_ID { get; set; }
		public List<string> AttributeTexts { get; set; }
        public Dictionary<string, IFC_BASE?> GetDirectAttributes();
        public Dictionary<string, IFC_BASE?> GetDerivedAttributes();
        public Dictionary<string, IFC_BASE?> GetInverseAttributes();
        public Dictionary<string, bool> GetWhereAttributes();
        public void SetByAttributeTexts();
        public string GetIFCFullText();
";
                writer.Write(contain);
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WriteCSharpEnum(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_ENUM.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("#nullable enable");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic abstract class IFC_ENUM : IFC_BASE");
                writer.WriteLine("\t{");

                string contain =
        @"
        public string Value { get; set; } = """";
        public string GetIFCText(bool includeClassName)
        {
            if (includeClassName)
            {
                return GetType().Name.ToUpper() + ""(."" + Value + "".)"";
            }
            else
            {
                return ""."" + Value + ""."";
            }
        }
";
                writer.Write(contain);
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WriteCSharpBasicType(string folderDir, string nameSpaceName)
        {
            foreach (var data in CSharpBasicDataTypes)
            {
                string name = data.Key;
                using (StreamWriter writer = new StreamWriter(folderDir + "IFC_" + name + ".cs"))
                {
                   
                    writer.WriteLine("using System;");
                    writer.WriteLine("using System.Collections.Generic;");
                    writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                    writer.WriteLine("#nullable enable");
                    writer.WriteLine("namespace " + nameSpaceName);
                    writer.WriteLine("{");

                  
                    string cSharpText = data.Value;
                    writer.WriteLine("\tpublic class IFC_" + name + ": IFC_BASE");
                    writer.WriteLine("\t{");

                    if (name == "LOGICAL")
                    {
                        writer.WriteLine("\t\tpublic bool Unknown {get; set;}");
                        writer.WriteLine("\t\tpublic " + cSharpText + " Value {get; set;}");
                        writer.WriteLine("\t\tpublic IFC_" + name + " () {Value = " + CSharpBasicDataDefaultValue[name] + "; Unknown = false;}");
                        writer.WriteLine("\t\tpublic IFC_" + name + " (" + cSharpText + " value) {Value = value; Unknown = false;}");
                    }
                    else
                    {
                        writer.WriteLine("\t\tpublic " + cSharpText + " Value {get; set;}");
                        writer.WriteLine("\t\tpublic IFC_" + name + " () {Value = " + CSharpBasicDataDefaultValue[name] + ";}");
                        writer.WriteLine("\t\tpublic IFC_" + name + " (" + cSharpText + " value) {Value = value;}");
                    }

                    List<string> ImplicitTexts = GetImplicitText("IFC_" + name, cSharpText);
                    foreach (string ImplicitText in ImplicitTexts) { writer.WriteLine(ImplicitText); }

                    writer.WriteLine("\t\tpublic string GetIFCText(bool includeClassName)");
                    writer.WriteLine("\t\t{");
                    if (name == "STRING")
                    {
                        string contain = 
@"			if (includeClassName)
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
                        string contain = 
@"            string text = Unknown? "".U."": (Value ? "".T."" : "".F."");
            return includeClassName ? (GetType().Name.ToUpper() + ""("" + text + "")"") : text;
";
                        writer.Write(contain);
                    }

                    else if (name == "BOOLEAN")
                    {
                        string contain = 
@"            string text = Value? "".T."": "".F."";
            return includeClassName ? (GetType().Name.ToUpper() + ""("" + text + "")"") : text;
";
                        writer.Write(contain);
                    }
                    else if (name == "INTEGER" || name == "BINARY")
                    {
                        string contain = 
@"            if (includeClassName)
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
                    else
                    {
                        string contain =
@"            string text = Value + """";
			if (!text.Contains("".""))
			{
				if (text.Contains(""E""))
				{
                    int a = text.IndexOf(""E"");
                    text = text.Insert(a, ""."");
                }
                else if (text.Contains(""e""))
                {
                    int a = text.IndexOf('e');
                    text = text.Insert(a, ""."");
                }
                else
                {
                    text += ""."";
                }
			}
			if (includeClassName)
			{
				return GetType().Name.ToUpper() + ""("" + text + "")"";
			}
			else
			{
                return text + """";
            }
";
                        writer.Write(contain);
                    }

                    writer.WriteLine("\t\t}");
                    writer.WriteLine("\t}");
                    writer.WriteLine("}");
                }
              
            }
        }

        private void WtiteCSharpAttributes(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_BASES.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("using System.Linq;");
                writer.WriteLine("using System.Text;");
                writer.WriteLine("using System.Threading.Tasks;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("#nullable enable");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic class IFC_BASES<T> : List<T>, IFC_BASE where T: IFC_BASE ");
                writer.WriteLine("\t{");
                string contain =
   @"
		public IFC_BASES() : base() { }
        public IFC_BASES(List<T>? value)
        {
            if (value != null)
            {
                foreach (var v in value)
                {
                    Add(v);
                }
            }
        }
        public IFC_BASES(IFC_BASES<T>? value)
        {
            if (value != null)
            {
                foreach (var v in value)
                {
                    Add(v);
                }
            }
        }
        public virtual string GetIFCText(bool includeClassName)
        {
            string text = ""("";
            int n = Count;
            for(int i = 0; i < n; i++)
            {
                text += this[i].GetIFCText(includeClassName) + (i < (n - 1) ? "","": "")"");
            }
            return text;
        }
";
                writer.Write(contain);
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }

            List<string> types = new List<string>()
            {
                "IFC_ARRAY",
                "IFC_BAG",
                "IFC_LIST",
                "IFC_SET"
            };
            foreach (string type in types)
            {
                using (StreamWriter writer = new StreamWriter(folderDir + type + ".cs"))
                {
                    writer.WriteLine("using System;");
                    writer.WriteLine("using System.Collections.Generic;");
                    writer.WriteLine("using System.Linq;");
                    writer.WriteLine("using System.Text;");
                    writer.WriteLine("using System.Threading.Tasks;");
                    writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                    writer.WriteLine("#nullable enable");
                    writer.WriteLine("namespace " + nameSpaceName);
                    writer.WriteLine("{");
                    writer.WriteLine("\tpublic class " + type + "<T> : IFC_BASES<T>, IFC_BASE where T: IFC_BASE ");
                    writer.WriteLine("\t{");
                    writer.WriteLine("\t\tpublic " + type + "() : base() { }");
                    writer.WriteLine("\t\tpublic " + type + "(List<T>? value) : base(value) { }");
                    writer.WriteLine("\t}");
                    writer.WriteLine("}");
                }
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


        public void WriteCSharpTest(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "IFC_TEST.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("using System.Linq;");
                writer.WriteLine("using System.Text;");
                writer.WriteLine("using System.Threading.Tasks;");
                writer.WriteLine("using System.IO;");
                writer.WriteLine("using System.Reflection;");
                writer.WriteLine("#pragma warning disable VSSpell001 // Spell Check");
                writer.WriteLine("#nullable enable");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic class IFC_TEST");
                writer.WriteLine("\t{");


                writer.WriteLine("\t\tpublic void TestLoad()");
                writer.WriteLine("\t\t{");

                foreach (var entity in Entities)
                {
                    if (!entity.IsAbstract)
                    {
                        writer.WriteLine("\t\t\tvar " + entity.Name + entity.VersionName + " = new " + nameSpaceName + "." + entity.VersionName + "." + entity.Name + "();");
                    }
                    writer.WriteLine("\t\t\tConsole.WriteLine(\"" + entity.Name + entity.VersionName + " = new " + nameSpaceName + "." + entity.VersionName + "." + entity.Name + "()\");");
                    
                }
                writer.WriteLine("\t\t}");

                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        #endregion
        #region Unity
        public void WriteUnityGetIFCGeometricRepresentationItemMesh(string folderDir, string nameSpaceName)
        {
            var classes = GetNonAbstractSubClass("IFCGeometricRepresentationItem");
            using (StreamWriter writer = new StreamWriter(folderDir + "GetIFCGeometricRepresentationItemMesh.txt"))
            {

                writer.WriteLine("\tMesh GetIFCGeometricRepresentationItemMesh(IFCGeometricRepresentationItem item, GraphicOption graphicOption)");
                writer.WriteLine("\t{");
                writer.WriteLine("\t\tswitch (item.GetType().Name.ToUpper())");
                writer.WriteLine("\t\t{");
                foreach (var entity in classes)
                {
                    writer.WriteLine("\t\t\tcase \"" + entity.ToUpper() + "\" : " + " return Get" + entity + "Mesh((" + entity + ") item, graphicOption);");
                }
                writer.WriteLine("\t\t}");
                writer.WriteLine("\t\treturn new Mesh();");
                writer.WriteLine("\t}");

                foreach (var entity in classes)
                {
                    writer.WriteLine("\tMesh Get" + entity + "Mesh("+ entity + " item, GraphicOption graphicOption)");
                    writer.WriteLine("\t{");

                    foreach (var v in Versions)
                    {
                        var versionClass = Entities.FirstOrDefault(e => e.Name == entity && e.VersionName == v);
                        
                        if(versionClass != null)
                        {
                            writer.WriteLine("\t\tif (item is " + nameSpaceName + "." + v + "." + entity + " " + v + "Item)");
                            writer.WriteLine("\t\t{");
                            writer.WriteLine("\t\t}");
                        }
                    }

                    writer.WriteLine("\t\treturn new Mesh();");
                    writer.WriteLine("\t}");
                }

            }
        }

        public void WriteUnityGetIFCProfileDefClosedCurveFace2s(string folderDir, string nameSpaceName)
        {
            var classes = GetNonAbstractSubClass("IFCProfileDef");
            using (StreamWriter writer = new StreamWriter(folderDir + "GetIFCProfileDefClosedCurveFace2s.txt"))
            {

                writer.WriteLine("\tList<ClosedCurveFace2> GetIFCProfileDefClosedCurveFace2s(IFCProfileDef item, GraphicOption graphicOption)");
                writer.WriteLine("\t{");
                writer.WriteLine("\t\tswitch (item.GetType().Name.ToUpper())");
                writer.WriteLine("\t\t{");
                foreach (var entity in classes)
                {
                    writer.WriteLine("\t\t\tcase \"" + entity.ToUpper() + "\" : " + " return Get" + entity + "ClosedCurveFace2s((" + entity + ") item, graphicOption);");
                }
                writer.WriteLine("\t\t}");
                writer.WriteLine("\t\treturn new List<ClosedCurveFace2>();");
                writer.WriteLine("\t}");

                foreach (var entity in classes)
                {
                    writer.WriteLine("\tList<ClosedCurveFace2> Get" + entity + "ClosedCurveFace2s(" + entity + " item, GraphicOption graphicOption)");
                    writer.WriteLine("\t{");

                    foreach (var v in Versions)
                    {
                        var versionClass = Entities.FirstOrDefault(e => e.Name == entity && e.VersionName == v);

                        if (versionClass != null)
                        {
                            writer.WriteLine("\t\tif (item is " + nameSpaceName + "." + v + "." + entity + " " + v + "Item)");
                            writer.WriteLine("\t\t{");
                            writer.WriteLine("\t\t}");
                        }
                    }

                    writer.WriteLine("\t\treturn new List<ClosedCurveFace2>();");
                    writer.WriteLine("\t}");
                }

            }
        }

        public void WriteUnityGetIFCCurveCurve2(string folderDir, string nameSpaceName)
        {
            var classes = GetNonAbstractSubClass("IFCCurve");
            using (StreamWriter writer = new StreamWriter(folderDir + "GetIFCCurveCurve2.txt"))
            {

                writer.WriteLine("\tCurve2 GetIFCCurveCurve2(IFCCurve item, GraphicOption graphicOption)");
                writer.WriteLine("\t{");
                writer.WriteLine("\t\tswitch (item.GetType().Name.ToUpper())");
                writer.WriteLine("\t\t{");
                foreach (var entity in classes)
                {
                    writer.WriteLine("\t\t\tcase \"" + entity.ToUpper() + "\" : " + " return Get" + entity + "Curve2((" + entity + ") item, graphicOption);");
                }
                writer.WriteLine("\t\t}");
                writer.WriteLine("\t\treturn new ClosedPointCurve2();");
                writer.WriteLine("\t}");

                foreach (var entity in classes)
                {
                    writer.WriteLine("\tCurve2 Get" + entity + "Curve2(" + entity + " item, GraphicOption graphicOption)");
                    writer.WriteLine("\t{");

                    foreach (var v in Versions)
                    {
                        var versionClass = Entities.FirstOrDefault(e => e.Name == entity && e.VersionName == v);

                        if (versionClass != null && !versionClass.IsAbstract)
                        {
                            writer.WriteLine("\t\tif (item is " + nameSpaceName + "." + v + "." + entity + " " + v + "Item)");
                            writer.WriteLine("\t\t{");
                            writer.WriteLine("\t\t}");
                        }
                    }

                    writer.WriteLine("\t\treturn new ClosedPointCurve2();");
                    writer.WriteLine("\t}");
                }

            }
        }
        #endregion


    }
}
