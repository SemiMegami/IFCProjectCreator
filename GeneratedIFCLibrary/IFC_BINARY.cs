using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace CSiBKK.IFC
{
	public class IFC_BINARY: IFC_BASE
	{
		public int Value {get; set;}
		public IFC_BINARY () {Value = 0;}
		public IFC_BINARY (int value) {Value = value;}
		public static implicit operator IFC_BINARY(int value) { return new IFC_BINARY(value);}
		public static implicit operator int(IFC_BINARY value) { return value.Value;}
		public string GetIFCText(bool includeClassName)
		{
            if (includeClassName)
			{
				return GetType().Name.ToUpper() + "(" + Value + ")";
			}
			else
			{
                return  Value + "";
            }
		}
	}
}
