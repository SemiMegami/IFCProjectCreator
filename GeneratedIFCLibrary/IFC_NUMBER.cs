using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace CSiBKK.IFC
{
	public class IFC_NUMBER: IFC_BASE
	{
		public double Value {get; set;}
		public IFC_NUMBER () {Value = 0;}
		public IFC_NUMBER (double value) {Value = value;}
		public static implicit operator IFC_NUMBER(double value) { return new IFC_NUMBER(value);}
		public static implicit operator double(IFC_NUMBER value) { return value.Value;}
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
