using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCInverseAttribute: IFCAttribute
    {
        public string RelatedAttributeName { get; set; }

        public IFCInverseAttribute() :base() 
        {
            RelatedAttributeName = "";
        }
    }
}
