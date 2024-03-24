using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public class IFC_BASES<T> : List<T>, IFC_BASE where T: IFC_BASE 
	{

		public IFC_BASES() : base() { }
        public IFC_BASES(List<T>? value)
        {
            if (value != null)
            {
                foreach (var v in value)
                {
                    Add(v);
                }
            }
        }
        public IFC_BASES(IFC_BASES<T>? value)
        {
            if (value != null)
            {
                foreach (var v in value)
                {
                    Add(v);
                }
            }
        }
        public virtual string GetIFCText(bool includeClassName)
        {
            string text = "(";
            int n = Count;
            for(int i = 0; i < n; i++)
            {
                text += this[i].GetIFCText(includeClassName) + (i < (n - 1) ? ",": ")");
            }
            return text;
        }
	}
}
