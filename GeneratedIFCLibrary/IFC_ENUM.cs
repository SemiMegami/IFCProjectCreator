using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace CSiBKK.IFC
{
	public abstract class IFC_ENUM : IFC_BASE
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
