using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{


    public class IFCParameterAttribute : IFCAttribute
    {
        public bool IsOptional { get; set; }
        public bool IsUnique { get; set; }
        public IFCParameterAttribute() : base()
        {
            IsOptional = false;
            IsUnique = false;
        }

        public override List<string> GetCSharpText()
        {
            return new List<string>
            {
                "\t\tpublic " +  (isOverride? "override ": "virtual ") + GetCSharpTypeText() + (IsOptional? "?":"?") + " " + Name + " { get; set; }"
            };
        }

        
    }
}
