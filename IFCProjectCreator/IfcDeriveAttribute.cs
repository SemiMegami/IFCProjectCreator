using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IfcDeriveAttribute : IfcAttribute
    {
        public string DeriveText { get; set; }

        public IfcDeriveAttribute() : base()
        {
            DeriveText = "";
        }
    }
}
