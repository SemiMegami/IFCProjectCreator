using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
#nullable enable
namespace IFC
{
	public class IFC_STRING: IFC_BASE
	{
		public string Value {get; set;}
		public IFC_STRING () {Value = "";}
		public IFC_STRING (string value) {Value = value;}
		public static implicit operator IFC_STRING(string value) { return new IFC_STRING(value);}
		public static implicit operator string(IFC_STRING value) { return value.Value;}
		public string GetIFCText(bool includeClassName)
		{
			if (includeClassName)
			{
				return GetType().Name.ToUpper() + "('" + Value + "')";
			}
			else
			{
                return "'" + Value + "'";
            }
		}
	}
}
