using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
#nullable enable
namespace IFC
{
	public interface IFC_I_ENTITY : IFC_BASE
	{

		public IFC_MODEL? Model { get; set; }
        public string IFC_ID { get; set; }
		public List<string> AttributeTexts { get; set; }
        public Dictionary<string, IFC_BASE?> GetDirectAttributes();
        public Dictionary<string, IFC_BASE?> GetDerivedAttributes();
        public Dictionary<string, IFC_BASE?> GetInverseAttributes();
        public Dictionary<string, bool> GetWhereAttributes();
        public void SetByAttributeTexts();
        public string GetIFCFullText();
	}
}
