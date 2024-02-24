using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public class IFC_Attributes<T> : List<T>, IFC_Attribute where T: IFC_Attribute 
	{

		public IFC_Attributes() : base() { }
        public IFC_Attributes(List<T>? value)
        {
            if (value != null)
            {
                foreach (var v in value)
                {
                    Add(v);
                }
            }
        }
        public IFC_Attributes(IFC_Attributes<T>? value)
        {
            if (value != null)
            {
                foreach (var v in value)
                {
                    Add(v);
                }
            }
        }
	}
}
