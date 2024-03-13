using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public interface IFC_Attribute
	{

        public string GetIFCText(bool includeClassName);
	}
}
