using System;
using System.Collections.Generic;
namespace IFC
{
	public abstract class Ifc_Entity
	{

		/// <summary>
		/// Model that contains this.
		/// </summary>
        public Ifc_Model? Model;

		/// <summary>
		/// ID used in an IFC file.
		/// </summary>
		public string ifcid;

        /// <summary>
		/// Get All Parameters
		/// </summary>
		/// <returns></returns>
        public abstract List<object?> GetParameters();

        /// <summary>
		/// Constructor
		/// </summary>
        public Ifc_Entity()
		{
			ifcid = string.Empty;
        }

        public string GetIfcFullText()
        {
            var parameters = GetParameters();
            string str = ifcid + "=" + GetType().Name.ToUpper() + "(";   

            if (parameters != null)
            {
                if (GetType().Name == "IfcPropertySingleValue")
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
                else if (GetType().Name == "IfcPropertyEnumeration")
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
                else if (GetType().Name == "IfcPropertyEnumeratedValue")
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
            else if (parameter is Ifc_Entity)
            {
                str += ((Ifc_Entity)parameter).ifcid;
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
                    || typeName == "IfcBSplineCurveForm"
                    || typeName == "IfcBSplineSurfaceForm"
                    || typeName == "IfcKnotType"
                    || typeName == "IfcPreferredSurfaceCurveRepresentation"
                    || typeName == "IfcSIPrefix"
                    || typeName == "IfcSIUnitName"
                    || typeName == "IfcSurfaceSide"
                    || typeName == "IfcTextPath"
                    || typeName == "IfcTransitionCode"
                    || typeName == "IfcTrimmingPreference")
                {
                    str += "" + parameter + "";
                }
                else if (typeName == "IfcBoolean" || typeName == "IfcLogical" || typeName == "BOOLEAN")
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
            return ifcid + " : " + GetType().Name;
        }
	}
}
