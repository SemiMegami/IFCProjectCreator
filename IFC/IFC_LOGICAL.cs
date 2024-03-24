using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public class IFC_LOGICAL: IFC_BASE
	{
		public bool Unknown {get; set;}
		public bool Value {get; set;}
		public IFC_LOGICAL () {Value = false; Unknown = false;}
		public IFC_LOGICAL (bool value) {Value = value; Unknown = false;}
		public static implicit operator IFC_LOGICAL(bool value) { return new IFC_LOGICAL(value);}
		public static implicit operator bool(IFC_LOGICAL value) { return value.Value;}
		public string GetIFCText(bool includeClassName)
		{
            string text = Unknown? ".U.": (Value ? ".T." : ".F.");
            return includeClassName ? (GetType().Name.ToUpper() + "(" + text + ")") : text;
		}
	}
}
