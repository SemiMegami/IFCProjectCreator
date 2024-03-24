using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public class IFC_ARRAY<T> : IFC_Attributes<T>, IFC_Attribute where T: IFC_Attribute 
	{
		public IFC_ARRAY() : base() { }
		public IFC_ARRAY(List<T>? value) : base(value) { }
	}
}