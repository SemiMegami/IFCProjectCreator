using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCSelectType : IFCClass
    {
        public List<IFCSelectAttribute> SelectAttributes;

        public bool IsGLOBAL;

        public bool IsEntity;

        public IFCSelectType(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            SelectAttributes = new List<IFCSelectAttribute>();
            IsGLOBAL = false;
            ClassType = IFCAttributeType.SELECT;
            IsEntity = false;
        }
        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_TYPE;");
            for(int i = 1; i < EXPLines.Count - 1; i++)
            {
                SubClassesNames.Add(EXPLines[i].Replace("(","").Replace(")","").Replace("\t","").Replace(",","").Replace(";","").Replace("Ifc","IFC"));
            }
        }

        public List<IFCSelectAttribute> AllSelectAttributes
        {
            get 
            {
                Dictionary<string, IFCSelectAttribute> attributes = new Dictionary<string, IFCSelectAttribute>();
                if (ParentSelects != null)
                {
                    foreach (var parent in ParentSelects)
                    {
                        foreach (var attribute in parent.AllSelectAttributes)
                        {
                            if (!attributes.ContainsKey(attribute.Name))
                            {
                                attributes.Add(attribute.Name, attribute);
                            }
                        }
                    }
                }

                foreach (var attribute in SelectAttributes)
                {
                    if (!attributes.ContainsKey(attribute.Name))
                    {
                        attributes.Add(attribute.Name, attribute);
                    }
                }
                return attributes.Values.ToList(); 
            }
        }

        public override List<string> GetCSharpTexts()
        {
            List<string> texts = GetCSharpSummaryTexts();
            texts.Add(GetCSharpHeaderText());
            
            // constructor
            texts.Add("\t{");
            var parents = AllParentSelects;
            foreach (IFCSelectAttribute attribute in SelectAttributes)
            {
                if(parents.FirstOrDefault(p => p.SelectAttributes.FirstOrDefault(e=>e.Name == attribute.Name) != null) == null)
                {
                    texts.AddRange(attribute.GetCSharpText());
                }
            }
            if(!IsGLOBAL)
            {
                foreach (IFCAttribute attribute in SelectAttributes)
                {
                    if(!attribute.includedInGLOBAL)
                    {
                        if (parents.FirstOrDefault(p => p.SelectAttributes.FirstOrDefault(e => e.Name == attribute.Name) != null) == null)
                        {
                            texts.AddRange(attribute.GetCSharpGLOBALText(DataSet));
                        }
                    }
                }
            }
            
            texts.Add("\t}");

            return texts;
        }

        protected override string GetCSharpTypeText()
        {
            return "interface";
        }

        /// <summary>
        /// Get text as class or interface
        /// </summary>
        /// <returns></returns>
        protected override string GetCSharpParentText()
        {
            if (ParentName.Length > 0)
            {
                return " : " + ParentName;
            }
            else
            {
                if(IsEntity)
                {
                    return ": IFC_I_ENTITY";

                }
                else
                {
                    return ": IFC_BASE";

                }
            }
        }

        public List<IFCAttributeType> GetAllIFCTypes()
        {
            List<IFCAttributeType> types = new List<IFCAttributeType>();
            foreach (var subClass in FinalSubclasses)
            {
                if (!types.Contains(subClass.ClassType))
                {
                    types.Add(subClass.ClassType);
                }
            }
            return types;
        }
    }
}
