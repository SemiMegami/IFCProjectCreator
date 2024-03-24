using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable VSSpell001 // Spell Check
namespace CSiBKK.IFC
{
	public class IFC_BAG<T> : IFC_BASES<T>, IFC_BASE where T: IFC_BASE 
	{
		public IFC_BAG() : base() { }
		public IFC_BAG(List<T>? value) : base(value) { }
	}
}
