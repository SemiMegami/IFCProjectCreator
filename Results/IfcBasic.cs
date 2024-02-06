using System;
using System.Collections.Generic;
namespace IFC;
{
	public class REAL
	{
		public static implicit operator REAL(double value) { return new REAL(double);}
		public static implicit operator double(REAL value) { return value.Value;}
	}
	public class INTEGER
	{
		public static implicit operator INTEGER(int value) { return new INTEGER(int);}
		public static implicit operator int(INTEGER value) { return value.Value;}
	}
	public class NUMBER
	{
		public static implicit operator NUMBER(double value) { return new NUMBER(double);}
		public static implicit operator double(NUMBER value) { return value.Value;}
	}
	public class LOGICAL
	{
		public static implicit operator LOGICAL(bool value) { return new LOGICAL(bool);}
		public static implicit operator bool(LOGICAL value) { return value.Value;}
	}
	public class BOOLEAN
	{
		public static implicit operator BOOLEAN(bool value) { return new BOOLEAN(bool);}
		public static implicit operator bool(BOOLEAN value) { return value.Value;}
	}
	public class BINARY
	{
		public static implicit operator BINARY(int value) { return new BINARY(int);}
		public static implicit operator int(BINARY value) { return value.Value;}
	}
	public class STRING
	{
		public static implicit operator STRING(string value) { return new STRING(string);}
		public static implicit operator string(STRING value) { return value.Value;}
	}
}
