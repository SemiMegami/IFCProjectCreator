using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable VSSpell001 // Spell Check
namespace CSiBKK.IFC
{
	public class IFC_SET<T> : IFC_BASES<T>, IFC_BASE where T: IFC_BASE 
	{
		public IFC_SET() : base() { }
		public IFC_SET(List<T>? value) : base(value) { }
	}
}
