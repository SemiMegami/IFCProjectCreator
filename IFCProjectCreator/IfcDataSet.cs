using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IfcDataSet
    {
        public List<IfcBasicType> BasicTypes { get; private set; }
        public List<IfcBasicTypeList> BasicTypeLists { get; private set; }
        public List<IfcEnumType> EnumTypes { get; private set; }
        public List<IfcSelectType> SelectTypes { get; private set; }
        public List<IfcEntity> Entities { get; private set; }
        public List<IfcFunction> Functions { get; private set; }

        public List<string> Versions { get; private set; }
        public IfcDataSet()
        {
            BasicTypes = new List<IfcBasicType>();
            BasicTypeLists = new List<IfcBasicTypeList>();
            EnumTypes = new List<IfcEnumType> ();
            SelectTypes = new List<IfcSelectType>();
            Entities = new List<IfcEntity>();
            Functions = new List<IfcFunction>();
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
                    string line = "";
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine() ?? "";
                        string[] words = line.Split(' ');

                       
                        if (words.Length > 0)
                        {
                            IfcBase item = null;
                            switch (words[0])
                            {
                                case "TYPE":
                                    if (line.Contains("ENUMERATION OF"))
                                    {
                                        item = new IfcEnumType(this, version);
                                        EnumTypes.Add((IfcEnumType)item);
                                    }
                                    else if (line.Contains(" = SELECT"))
                                    {
                                        item = new IfcSelectType(this, version);
                                        SelectTypes.Add((IfcSelectType)item);
                                    }
                                    else if (line.Contains("]"))
                                    {
                                        item = new IfcBasicTypeList(this, version);
                                        BasicTypeLists.Add((IfcBasicTypeList)item);
                                    }
                                    else
                                    {
                                        item = new IfcBasicType(this, version);
                                        BasicTypes.Add((IfcBasicType)item);
                                    }
                                    break;
                                case "ENTITY":
                                    item = new IfcEntity(this, version);
                                    Entities.Add((IfcEntity)item);
                                    break;
                                case "FUNCTION":
                                    item = new IfcFunction(this, version);
                                    Functions.Add((IfcFunction)item);
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

        private void SetParent()
        {
            List<IfcBase> items = GetItems();

            foreach(var selectType in SelectTypes)
            {
                foreach (var subClassName in selectType.SubClassesNames)
                {
                    IfcBase subClass = items.First(e => e.Name == subClassName && e.VersionName == selectType.VersionName);
                    subClass.InterfaceNames.Add(selectType.Name);
                    subClass.ParentInterfaces.Add(selectType);
                    selectType.SubClasses.Add(subClass);
                }
            }
            foreach(var entity in Entities)
            {
                List<IfcEntity> parents = Entities.Where(e => e.Name == entity.ParentName && e.VersionName == entity.VersionName).ToList();
                if(parents.Count > 0)
                {
                    IfcEntity parent = parents.First();
                    entity.ParentClass = parent;
                    parent.SubClassesNames.Add(entity.Name);
                    parent.SubClasses.Add(entity);
                }
            }
            foreach (var basicType in BasicTypes)
            {
                List<IfcBasicType> parents = BasicTypes.Where(e => e.Name == basicType.ParentName && e.VersionName == basicType.VersionName).ToList();
                if (parents.Count > 0)
                {
                    IfcBasicType parent = parents.First();
                    basicType.ParentClass = parent;
                    parent.SubClassesNames.Add(basicType.Name);
                    parent.SubClasses.Add(basicType);
                }
            }
        }
    

        public List<IfcBase> GetItems()
        {
            List<IfcBase> items = new List<IfcBase>();
            items.AddRange(BasicTypes);
            items.AddRange(BasicTypeLists);
            items.AddRange(EnumTypes);
            items.AddRange(SelectTypes);
            items.AddRange(Entities);
            items.AddRange(Functions);
            return items;
        }

        public List<IfcBase> GetItems(string version) { 
            return GetItems().Where(e=> e.VersionName == version).ToList();
        }
    }
}
