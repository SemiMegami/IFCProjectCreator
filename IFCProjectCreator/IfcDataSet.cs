﻿using Microsoft.SqlServer.Management.XEvent;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace IFCProjectCreator
{
    public class IFCDataSet
    {
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

        public List<IFCBasicType> BasicTypes { get; private set; }
        public List<IFCBasicTypeList> BasicTypeLists { get; private set; }
        public List<IFCEnumType> EnumTypes { get; private set; }
        public List<IFCSelectType> SelectTypes { get; private set; }
        public List<IFCEntity> Entities { get; private set; }
        public List<IFCFunction> Functions { get; private set; }
        public List<string> Versions { get; private set; }

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
        }

        /// <summary>
        /// Read an EXP file to store data
        /// </summary>
        /// <param name="path">File Path</param>
        /// <param name="version">Version Name</param>
        public void ReadExp(string path, string version)
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
            SetParent();
            SetAtribute();
            
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
                        subClass.ParentInterfaces.Add(selectType);
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

            // set attribute for select tyoe
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
                            }
                        }

                        if (isCommon)
                        {
                            commonAttributes.Add(attributesSets[0].First(e => e.Name == attributeName));
                        }
                    }
                    foreach (var attribute in commonAttributes)
                    {
                        if (selectType.SelectAttributes.FirstOrDefault(e => e.Name == attribute.Name) == null)
                        {
                            selectType.SelectAttributes.Add(new IFCSelectAttribute()
                            {
                                Name = attribute.Name,
                                TypeName = attribute.TypeName,
                                Aggregation = attribute.Aggregation,
                                AttributeType = attribute.AttributeType
                            });
                        }


                    }
                }
            }

            // Additional select attribute
            foreach (var entity in Entities)
            {
                var allAttribute = entity.AllAttributes;
                Dictionary<string, IFCSelectAttribute> selectarributeDict = new Dictionary<string, IFCSelectAttribute>();

                var parents = entity.ParentSelects;
                foreach(var parent in parents)
                {
                    foreach(var attribute in parent.SelectAttributes)
                    {
                        if (!(selectarributeDict.ContainsKey(attribute.Name)))
                        {
                            selectarributeDict.Add(attribute.Name, attribute);
                        }
                    }
                }
                foreach(var att in selectarributeDict)
                {
                    var attribute = att.Value;

                    if(allAttribute.FirstOrDefault(e => e.Name == attribute.Name) == null && entity.AdditionalSelectAttibutes.FirstOrDefault(e => e.Name == attribute.Name) == null)
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

                var parents = enumType.ParentSelects;
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
                        //if (parent.DeriveAttributes.Where(x => x.Name == attribute.Name).Count() > 0)
                        //{
                        //    attribute.isOverride = true;
                        //}
                        //if (parent.ParameterAttributes.Where(x => x.Name == attribute.Name).Count() > 0)
                        //{
                        //    attribute.isOverride = true;
                        //}
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
            return GetItems().Where(e=> e.VersionName == version).ToList();
        }

        /// <summary>
        /// Write C# classes file in specificed folder
        /// </summary>
        /// <param name="folderDir"></param>
        public void WriteCSharp(string folderDir, string nameSpaceName)
        {
            WtiteCSharpModel(folderDir, nameSpaceName);
            WtiteCSharpEntity(folderDir, nameSpaceName);
            WtiteCSharpBasicType(folderDir, nameSpaceName);
            foreach (var version in Versions)
            {
                using (StreamWriter writer = new StreamWriter(folderDir + version + ".cs"))
                {
                    var items = GetItems(version);
                    writer.WriteLine("using System;");
                    writer.WriteLine("using System.Collections.Generic;");
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
        }

        private void WtiteCSharpModel(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "Model.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic class Model");
                writer.WriteLine("\t{");
        
                string contain =
        @"
        /// <summary>
        /// IFC Items
        /// </summary>
		public List<Entity> Items;
        
        /// <summary>
        /// Constructure
        /// </summary>
        public Model()
        {
            Items = new List<Entity>();
        }

        /// <summary>
        /// Return IFC Item with specificed type
        /// </summary>
        /// <typeparam name=""T""></typeparam>
        /// <returns></returns>
        public List<T> GetItems<T>() where T : Entity
		{
			List<Entity> items = Items.Where(x => x is T).ToList();
            List < T > results = new List<T>();
			foreach (var item in items)
			{
				results.Add((T)item);
			}
			return results;
        }
 ";
                writer.Write(contain);

                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WtiteCSharpEntity(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + "Entity.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("namespace " + nameSpaceName);
                writer.WriteLine("{");
                writer.WriteLine("\tpublic class Entity");
                writer.WriteLine("\t{");

                string contain =
       @"
		/// <summary>
		/// Model that contains this.
		/// </summary>
        public Model? Model;

		/// <summary>
		/// ID used in an IFC file.
		/// </summary>
		public string? IFC_ID;
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
