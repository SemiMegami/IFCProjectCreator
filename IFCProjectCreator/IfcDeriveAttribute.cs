using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCDeriveAttribute : IFCAttribute
    {
        public string DeriveText { get; set; }
  
        public IFCDeriveAttribute() : base()
        {
            isReadOnly = true;
            DeriveText = "";
        }

        public override List<string> GetCSharpText()
        {
            return new List<string>
            {
                "\t\t//DERIVE",
                "\t\tpublic " + (isOverride? "override ": "virtual ") + GetCSharpTypeText() + "? " + Name + " {get {return null;}}",
             
            };
        }
    }
}
