using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{


    public class ParameterAttribute : IfcAttribute
    {
        public bool IsOptional { get; set; }
        public bool IsUnique { get; set; }
        public ParameterAttribute() : base() 
        {
            IsOptional = false;
            IsUnique = false;
        }
    }
}
