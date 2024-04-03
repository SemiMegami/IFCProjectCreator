using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable VSSpell001 // Spell Check
#nullable enable
namespace IFC
{
	public class IFC_ARRAY<T> : IFC_BASES<T>, IFC_BASE where T: IFC_BASE 
	{
		public IFC_ARRAY() : base() { }
		public IFC_ARRAY(List<T>? value) : base(value) { }
	}
}
