using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCWhereAttribute : IFCAttribute
    {
        public string WhereText { get; set; }
        public IFCWhereAttribute() : base() 
        {
            WhereText = "";
        }

        public override List<string> GetCSharpText()
        {
            return new List<string>()
            {
                  "\t\tpublic " + (isOverride?"override":"virtual") +  " bool " + Name,
                  "\t\t{",
                  "\t\t\tget",
                  "\t\t\t{",
                  "\t\t\t\treturn true;",
                  "\t\t\t}",
                  "\t\t}"
            };
                
                
              
        }
    }
}
