using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IfcInverseAttribute: IfcAttribute
    {
        public string RelatedAttributeName { get; set; }

        public IfcInverseAttribute() :base() 
        {
            RelatedAttributeName = "";
        }
    }
}
