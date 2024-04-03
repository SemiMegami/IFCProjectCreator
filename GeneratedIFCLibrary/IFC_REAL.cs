using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
#nullable enable
namespace IFC
{
	public class IFC_REAL: IFC_BASE
	{
		public double Value {get; set;}
		public IFC_REAL () {Value = 0;}
		public IFC_REAL (double value) {Value = value;}
		public static implicit operator IFC_REAL(double value) { return new IFC_REAL(value);}
		public static implicit operator double(IFC_REAL value) { return value.Value;}
		public string GetIFCText(bool includeClassName)
		{
            string text = Value + "";
			if (!text.Contains("."))
			{
				if (text.Contains("E"))
				{
                    int a = text.IndexOf("E");
                    text = text.Insert(a, ".");
                }
                else if (text.Contains("e"))
                {
                    int a = text.IndexOf('e');
                    text = text.Insert(a, ".");
                }
                else
                {
                    text += ".";
                }
			}
			if (includeClassName)
			{
				return GetType().Name.ToUpper() + "(" + text + ")";
			}
			else
			{
                return text + "";
            }
		}
	}
}
