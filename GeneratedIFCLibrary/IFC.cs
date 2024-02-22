using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public interface IFC
	{

		public IFC_Model? Model { get; set; }
        public string IFC_ID { get; set; }
        public List<object?> GetParameters();
        public string GetIFCFullText();
	}
}
