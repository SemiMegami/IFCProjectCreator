using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
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
	public class IFC_BINARY: IFC_BASE
	{
		public int Value {get; set;}
		public IFC_BINARY () {Value = 0;}
		public IFC_BINARY (int value) {Value = value;}
		public static implicit operator IFC_BINARY(int value) { return new IFC_BINARY(value);}
		public static implicit operator int(IFC_BINARY value) { return value.Value;}
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
