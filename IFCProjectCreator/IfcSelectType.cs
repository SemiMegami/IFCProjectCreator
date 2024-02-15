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

        public IFCSelectType(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            SelectAttributes = new List<IFCSelectAttribute>();
        }
        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_TYPE;");
            for(int i = 1; i < EXPLines.Count - 1; i++)
            {
                SubClassesNames.Add(EXPLines[i].Replace("(","").Replace(")","").Replace("\t","").Replace(",","").Replace(";",""));
            }      
        }



        public override List<string> GetCSharpTexts()
        {
            List<string> texts = GetCSharpSummaryTexts();
            texts.Add(GetCSharpHeaderText());
            
            // constructor
            texts.Add("\t{");
            var parents = ParentSelects;
            foreach (IFCAttribute attribute in SelectAttributes)
            {
                if(parents.FirstOrDefault(p => p.SelectAttributes.FirstOrDefault(e=>e.Name == attribute.Name) != null) == null)
                {
                    texts.AddRange(attribute.GetCSharpText());
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
                return "";
            }
        }
    }
}
