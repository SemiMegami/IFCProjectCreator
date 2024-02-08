using System;
using System.Collections.Generic;
namespace IFC
{
	public class Entity
	{

		/// <summary>
		/// Model that contains this.
		/// </summary>
        public Model? Model;

		/// <summary>
		/// ID used in an IFC file.
		/// </summary>
		public string? IFC_ID;
	}
}
