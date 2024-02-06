using Microsoft.SqlServer.Management.XEvent;
using System;
using System.Data;

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
                    reader.Close();
                }
            }
            SetParent();
        }

        /// <summary>
        /// Link parents
        /// </summary>
        private void SetParent()
        {
            List<IFCClass> items = GetItems();

            foreach(var selectType in SelectTypes)
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
            foreach(var entity in Entities)
            {
                List<IFCEntity> parents = Entities.Where(e => e.Name == entity.ParentName && e.VersionName == entity.VersionName).ToList();
                if(parents.Count > 0)
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
                    writer.WriteLine("namespace " + nameSpaceName + "." + version + ";");
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
            using (StreamWriter writer = new StreamWriter(folderDir + nameSpaceName + "IFCMODEL.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("namespace " + nameSpaceName + ";");
                writer.WriteLine("{");
                writer.Write("\t public class IFCMODEL");
                writer.WriteLine("\t{");
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WtiteCSharpEntity(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + nameSpaceName + "IFCENTITY.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("namespace " + nameSpaceName + ";");
                writer.WriteLine("{");
                writer.Write("\t public class IFCENTITY");
                writer.WriteLine("\t{");
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }

        private void WtiteCSharpBasicType(string folderDir, string nameSpaceName)
        {
            using (StreamWriter writer = new StreamWriter(folderDir + nameSpaceName + "IFCBASIC.cs"))
            {
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("namespace " + nameSpaceName + ";");
                writer.WriteLine("{");
                foreach (var data in CSharpBasicDataTypes)
                {
                    string name = data.Key;
                    string cSharpText = data.Value;
                    writer.WriteLine("\tpublic class " + data.Key);
                    writer.WriteLine("\t{");
                    writer.WriteLine("\t\tpublic static implicit operator " + name + "(" + cSharpText + " value) { return new " + name + "(" + cSharpText + ");}");
                    writer.WriteLine("\t\tpublic static implicit operator " + cSharpText + "(" + name + " value) { return value.Value;}");

                    writer.WriteLine("\t}");
                }
                writer.WriteLine("}");
            }
        }

    }
}
