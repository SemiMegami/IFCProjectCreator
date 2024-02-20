using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCSelectAttribute : IFCAttribute
    {
        public bool isClassAttribute;

        public IFCSelectAttribute() : base()
        {
            isClassAttribute = false;
        }
        public override List<string> GetCSharpText()
        {
            var typeText = GetCSharpTypeText();
            if(typeText != "int" && typeText != "float" && typeText != "double" && typeText != "bool") 
            {
                typeText = typeText + "?";
            }

            return new List<string>
            {
                "\t\tpublic " + (isClassAttribute?"virtual ":"") + typeText + " " + Name + " { get; " + (isClassAttribute?"set; ":"") +" }"
            };
        }
    }
}
