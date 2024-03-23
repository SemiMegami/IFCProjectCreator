using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public class IFC_BAG<T> : IFC_Attributes<T>, IFC_Attribute where T: IFC_Attribute 
	{
		public IFC_BAG() : base() { }
		public IFC_BAG(List<T>? value) : base(value) { }
	}
}
