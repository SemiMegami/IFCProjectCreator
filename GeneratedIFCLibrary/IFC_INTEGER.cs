using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
#nullable enable
namespace IFC
{
	public class IFC_INTEGER: IFC_BASE
	{
		public int Value {get; set;}
		public IFC_INTEGER () {Value = 0;}
		public IFC_INTEGER (int value) {Value = value;}
		public static implicit operator IFC_INTEGER(int value) { return new IFC_INTEGER(value);}
		public static implicit operator int(IFC_INTEGER value) { return value.Value;}
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
