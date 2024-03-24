using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace CSiBKK.IFC
{
	public class IFC_BOOLEAN: IFC_BASE
	{
		public bool Value {get; set;}
		public IFC_BOOLEAN () {Value = false;}
		public IFC_BOOLEAN (bool value) {Value = value;}
		public static implicit operator IFC_BOOLEAN(bool value) { return new IFC_BOOLEAN(value);}
		public static implicit operator bool(IFC_BOOLEAN value) { return value.Value;}
		public string GetIFCText(bool includeClassName)
		{
            string text = Value? ".T.": ".F.";
            return includeClassName ? (GetType().Name.ToUpper() + "(" + text + ")") : text;
		}
	}
}
