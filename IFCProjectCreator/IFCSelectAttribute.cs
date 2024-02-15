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
            return new List<string>
            {
                "\t\tpublic " + (isClassAttribute?"virtual ":"") + GetCSharpTypeText() + "?" + " " + Name + " { get; " + (isClassAttribute?"set; ":"") +" }"
            };
        }
    }
}
