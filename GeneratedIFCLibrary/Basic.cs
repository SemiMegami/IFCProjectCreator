using System;
using System.Collections.Generic;
namespace IFC
{
	public class REAL
	{
		public double Value {get; set;}
		public REAL () {}
		public REAL (double value) {Value = value;}
		public static implicit operator REAL(double value) { return new REAL(value);}
		public static implicit operator double(REAL value) { return value.Value;}
	}
	public class INTEGER
	{
		public int Value {get; set;}
		public INTEGER () {}
		public INTEGER (int value) {Value = value;}
		public static implicit operator INTEGER(int value) { return new INTEGER(value);}
		public static implicit operator int(INTEGER value) { return value.Value;}
	}
	public class NUMBER
	{
		public double Value {get; set;}
		public NUMBER () {}
		public NUMBER (double value) {Value = value;}
		public static implicit operator NUMBER(double value) { return new NUMBER(value);}
		public static implicit operator double(NUMBER value) { return value.Value;}
	}
	public class LOGICAL
	{
		public bool Value {get; set;}
		public LOGICAL () {}
		public LOGICAL (bool value) {Value = value;}
		public static implicit operator LOGICAL(bool value) { return new LOGICAL(value);}
		public static implicit operator bool(LOGICAL value) { return value.Value;}
	}
	public class BOOLEAN
	{
		public bool Value {get; set;}
		public BOOLEAN () {}
		public BOOLEAN (bool value) {Value = value;}
		public static implicit operator BOOLEAN(bool value) { return new BOOLEAN(value);}
		public static implicit operator bool(BOOLEAN value) { return value.Value;}
	}
	public class BINARY
	{
		public int Value {get; set;}
		public BINARY () {}
		public BINARY (int value) {Value = value;}
		public static implicit operator BINARY(int value) { return new BINARY(value);}
		public static implicit operator int(BINARY value) { return value.Value;}
	}
	public class STRING
	{
		public string Value {get; set;}
		public STRING () {}
		public STRING (string value) {Value = value;}
		public static implicit operator STRING(string value) { return new STRING(value);}
		public static implicit operator string(STRING value) { return value.Value;}
	}
}