using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public interface IFC_Entity : IFC_Attribute
	{

		public IFC_Model? Model { get; set; }
        public string IFC_ID { get; set; }
		public List<string> AttributeTexts { get; set; }
        public Dictionary<string, IFC_Attribute?> GetDirectAttributes();
        public Dictionary<string, IFC_Attribute?> GetDerivedAttributes();
        public Dictionary<string, IFC_Attribute?> GetInverseAttributes();
        public Dictionary<string, bool> GetWhereAttributes();
        public string GetIFCFullText();
	}
}
