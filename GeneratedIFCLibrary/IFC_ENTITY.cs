using System;
using System.Collections.Generic;
#pragma warning disable VSSpell001 // Spell Check
#nullable enable
namespace IFC
{
	public abstract class IFC_ENTITY : IFC_I_ENTITY, IFC_BASE
	{

		/// <summary>
		/// Model that contains this.
		/// </summary>
        public IFC_MODEL? Model { get; set; }

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
        public abstract Dictionary<string, IFC_BASE?> GetDirectAttributes();

        /// <summary>
		/// Get derived attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, IFC_BASE?> GetDerivedAttributes();

        /// <summary>
		/// Get inverse attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, IFC_BASE?> GetInverseAttributes();

        /// <summary>
		/// Get inverse attributes
		/// </summary>
		/// <returns></returns>
        public abstract Dictionary<string, bool> GetWhereAttributes();

        /// <summary>
		/// Constructor
		/// </summary>
        public IFC_ENTITY()
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

        protected List<string>? SplitList(string input)
		{
            int index1 = input.IndexOf("(");
            int index2 = input.LastIndexOf(")");
			if(index1 > -1 && index2 > -1)
			{
                string inputTypeName = input.Substring(0, index1);
                string trim = input.Substring(index1 + 1, index2 - index1 - 1);

                List<string> outputText = new List<string>();
                int bracketCount = 0;
                bool readingString = false;
                char[] chars = trim.ToCharArray();
                int n = chars.Length;
                char c;
                string scanningText = "";
                for (int i = 0; i < n; i++)
                {
                    c = chars[i];
                    if (c == '\'')
                    {
                        readingString = !readingString; // toggle 
                        scanningText += c;
                    }
                    else if (!readingString && c == '(')
                    {
                        scanningText += c;
                        bracketCount++;
                    }
                    else if (!readingString && c == ')')
                    {
                        bracketCount--;
                        scanningText += c;
                    }
                    else if (!readingString && c == ',' && bracketCount == 0)
                    {
                    }
                    else
                    {
                        scanningText += c;
                    }
                    if (i == n - 1 || (!readingString && c == ',' && bracketCount == 0))
                    {
                        outputText.Add(scanningText);
                        scanningText = "";
                    }
                }
                return outputText;
            }
            return null;
        }
	}
}
