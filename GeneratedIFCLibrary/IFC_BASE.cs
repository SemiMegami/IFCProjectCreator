using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
#nullable enable
namespace IFC
{
	public interface IFC_BASE
	{

        public string GetIFCText(bool includeClassName);
	}
}
