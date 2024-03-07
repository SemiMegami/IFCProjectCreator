using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public abstract class IFC_Enum : IFC_Attribute
	{

        public string Value { get; set; } = "";
        public string GetIFCText(bool includeClassName)
        {
            if (includeClassName)
            {
                return GetType().Name.ToUpper() + "(." + Value + ".)";
            }
            else
            {
                return "." + Value + ".";
            }
        }
	}
}
