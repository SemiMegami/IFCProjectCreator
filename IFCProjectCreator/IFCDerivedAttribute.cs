using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCDerivedAttribute : IFCAttribute
    {
        public string DeriveText { get; set; }
        public IFCEntity? Entity { get; set; }
  
        public IFCDerivedAttribute() : base()
        {
            isReadOnly = true;
            DeriveText = "";
        }

        public override List<string> GetCSharpText()
        {
            if(Entity != null)
            {
                return new List<string>
            {
               
                "\t\tpublic " + (isOverride? "override ": "virtual ") + GetCSharpTypeText() + "? " + Name,
                "\t\t{",
                "\t\t\tget",
                "\t\t\t{",
                "\t\t\t\t//MANUAL : " + Entity.VersionName + "." + Entity.Name + "." + Name,
                "\t\t\t\t// " + DeriveText,
                "\t\t\t\treturn null;",
                "\t\t\t\t//END_MANUAL",
                "\t\t\t}",
                "\t\t}",
            };
            }
            else
            {
                return new List<string> {};
            }
            
        }
    }
}
