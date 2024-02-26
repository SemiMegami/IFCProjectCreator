using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public interface IFC_Entity : IFC_Attribute
	{

		public IFC_Model? Model { get; set; }
        public string IFC_ID { get; set; }
        public List<IFC_Attribute?> GetDirectAttributes();
        public List<IFC_Attribute?> GetDerivedAttributes();
        public List<IFC_Attribute?> GetInverseAttributes();
        public string GetIFCFullText();
	}
}
