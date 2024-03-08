using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
namespace IFC
{
	public abstract class IFC_ClassEntity : IFC_Entity, IFC_Attribute
	{

		/// <summary>
		/// Model that contains this.
		/// </summary>
        public IFC_Model? Model { get; set; }

		/// <summary>
		/// ID used in an IFC file.
		/// </summary>
		public string IFC_ID { get; set; }

	    /// <summary>
		/// Attribute Texts.
		/// </summary>
		public List<string> AttributeTexts { get; set; }

        /// <summary>
		/// Get All direct attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, IFC_Attribute?> GetDirectAttributes();

        /// <summary>
		/// Get derived attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, IFC_Attribute?> GetDerivedAttributes();

        /// <summary>
		/// Get inverse attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, IFC_Attribute?> GetInverseAttributes();

        /// <summary>
		/// Get inverse attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, bool> GetWhereAttributes();

        /// <summary>
		/// Constructor
		/// </summary>
        public IFC_ClassEntity()
		{
			IFC_ID = string.Empty;
            AttributeTexts = new List<string>();
        }
        /// <summary>
		/// Set all attributes by current "AttributeTexts"
		/// </summary>
        public virtual void SetByAttributeTexts()
        {
        }

        public string GetIFCText(bool includeClassName)
        {
            return "#" + IFC_ID;
        }

        public abstract string GetIFCFullText();

        public override string ToString()
        {
            return IFC_ID + " : " + GetType().Name;
        }
	}
}
