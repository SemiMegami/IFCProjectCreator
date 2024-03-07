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

        public string GetIFCText(bool includeClassName)
        {
            return "#" + IFC_ID;
        }

        public string GetIFCFullText()
        {
            var parameters = GetDirectAttributes().Values.ToList();
            string str = IFC_ID + "=" + GetType().Name.ToUpper() + "(";   

            if (parameters != null)
            {
                if (GetType().Name == "IFCPropertySingleValue")
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        var parameter = parameters[i];
                        if(parameter!= null)
                        {
                            if (i == 2)
                            {
                                str += parameter.GetType().Name.ToUpper() + "(" + GetParameterText(parameter) + ")";
                            }
                            else
                            {
                                str += GetParameterText(parameter);
                            }
                            if (i < parameters.Count - 1)
                            {
                                str += ",";
                            }
                        }
                        else
                        {
                            str += GetParameterText(parameter);
                            if (i < parameters.Count - 1)
                            {
                                str += ",";
                            }
                        }
                    }
                }
                else if (GetType().Name == "IFCPropertyEnumeration")
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {

                        dynamic? parameter = parameters[i];
                        if (parameter != null)
                        {
                            if (i == 1)
                            {
                                var paramTexts = parameter.ToArray();
                                str += "(";
                                for (int j = 0; j < paramTexts.Length; j++)
                                {
                                    str += "IFCTEXT('" + paramTexts[j] + "')";
                                    if (j < paramTexts.Length - 1)
                                    {
                                        str += ",";
                                    }
                                }
                                str += ")";
                            }
                            else
                            {
                                str += GetParameterText(parameter);
                            }

                            if (i < parameters.Count - 1)
                            {
                                str += ",";
                            }
                        }
                        else
                        {
                            str += GetParameterText(parameter);
                            if (i < parameters.Count - 1)
                            {
                                str += ",";
                            }
                        }

                    }
                }
                else if (GetType().Name == "IFCPropertyEnumeratedValue")
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {

                        dynamic? parameter = parameters[i];
                        if (parameter != null)
                        {
                            if (i == 2)
                            {
                                var paramTexts = parameter.ToArray();
                                str += "(";
                                for (int j = 0; j < paramTexts.Length; j++)
                                {
                                    str += "IFCTEXT('" + paramTexts[j] + "')";
                                    if (j < paramTexts.Length - 1)
                                    {
                                        str += ",";
                                    }
                                }
                                str += ")";
                            }
                            else
                            {
                                str += GetParameterText(parameter);
                            }
                            if (i < parameters.Count - 1)
                            {
                                str += ",";
                            }
                        }
                        else
                        {
                            str += GetParameterText(parameter);
                            if (i < parameters.Count - 1)
                            {
                                str += ",";
                            }
                        }
                    }
                }


                else
                {
                    for (int i = 0; i < parameters.Count; i++)
                    {
                        var parameter = parameters[i];
                        if(parameter != null)
                        {
                            str += GetParameterText(parameter);
                            if (i < parameters.Count - 1)
                            {
                                str += ",";
                            }
                        }
                        else
                        {
                            str += GetParameterText(parameter);
                            if (i < parameters.Count - 1)
                            {
                                str += ",";
                            }
                        }
                    }
                }
                str += ");";
            }
            return str;
        }


        private static string GetParameterText(dynamic? parameter)
        {

            string str = "";
            if (parameter == null)
            {
                str += "$";
            }
            else if (parameter is IFC_ClassEntity)
            {
                str += ((IFC_ClassEntity)parameter).IFC_ID;
            }
            else if (parameter.GetType().GetInterface("IEnumerable") != null)
            {
                str += "(";
                for (int i = 0; i < parameter.Count; i++)
                {

                    str += GetParameterText(parameter[i]);
                    if (i < parameter.Count - 1)
                    {
                        str += ",";
                    }
                }
                str += ")";
            }
            else
            {
                string typeName = parameter.GetType().Name;

                if (parameter is STRING)
                {
                    str += "'" + parameter.ToString() + "'";
                }
                else if (typeName.Contains("Enum")
                    || typeName == "IFCBSplineCurveForm"
                    || typeName == "IFCBSplineSurfaceForm"
                    || typeName == "IFCKnotType"
                    || typeName == "IFCPreferredSurfaceCurveRepresentation"
                    || typeName == "IFCSIPrefix"
                    || typeName == "IFCSIUnitName"
                    || typeName == "IFCSurfaceSide"
                    || typeName == "IFCTextPath"
                    || typeName == "IFCTransitionCode"
                    || typeName == "IFCTrimmingPreference")
                {
                    str += "" + parameter + "";
                }
                else if (typeName == "IFCBoolean" || typeName == "IFCLogical" || typeName == "BOOLEAN")
                {
                    if ((bool)parameter)
                    {
                        str += ".T.";
                    }
                    else
                    {
                        str += ".F.";
                    }
                }
                else
                {
                    str += (float)parameter;
                }
            }
            return str;
        }

        public override string ToString()
        {
            return IFC_ID + " : " + GetType().Name;
        }
	}
}
