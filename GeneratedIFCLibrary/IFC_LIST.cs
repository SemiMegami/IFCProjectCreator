using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable VSSpell001 // Spell Check
namespace CSiBKK.IFC
{
	public class IFC_LIST<T> : IFC_BASES<T>, IFC_BASE where T: IFC_BASE 
	{
		public IFC_LIST() : base() { }
		public IFC_LIST(List<T>? value) : base(value) { }
	}
}
