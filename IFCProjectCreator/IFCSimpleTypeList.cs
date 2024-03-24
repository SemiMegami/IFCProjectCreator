using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCSimpleTypeList : IFCSimpleType
    {
        public IFCSimpleTypeList(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            ClassType = IFCAttributeType.SIMPLELIST;
        }

        public override List<string> GetCSharpTexts()
        {
            string cSharpText = GetCSharpType();
            List<string> texts = GetCSharpSummaryTexts();

            string parentName = ParentName;
            if (DataSet.CSharpBasicDataTypes.ContainsKey(ParentName))
            {
                parentName = "IFC_" + ParentName;
            }

            string header = "\tpublic class " + Name + " : IFC_LIST<" + parentName + ">" + ", ";

            foreach (var inf in InterfaceNames)
            {
                header += inf + ", ";
            }
            header += DataSet.GLOBALName + "." + Name;
            texts.Add(header);
            texts.Add("\t{");
            var selects = DataSet.SelectTypes.Where(e => e.VersionName == VersionName).ToList();
            if (cSharpText.Length > 0)
            {
                texts.Add("\t\tpublic "+ cSharpText + " Value");
                texts.Add("\t\t{");
                texts.Add("\t\t\tget");
                texts.Add("\t\t\t{");
                texts.Add("\t\t\t\t" + cSharpText + " values = new " + cSharpText + " ();" );
                texts.Add("\t\t\t\tforeach(var value in this)");
                texts.Add("\t\t\t\t{");
                texts.Add("\t\t\t\t\tvalues.Add(value);");
                texts.Add("\t\t\t\t}");
                texts.Add("\t\t\t\treturn values;");
                texts.Add("\t\t\t}");
                texts.Add("\t\t\tset");
                texts.Add("\t\t\t{");
                texts.Add("\t\t\t\tValue = value;");
                texts.Add("\t\t\t}");
                texts.Add("\t\t}");
                texts.Add("\t\tpublic " + Name + "() : base () { }");
                texts.Add("\t\tpublic " + Name + "(" + cSharpText + " value)");
                texts.Add("\t\t{");
                texts.Add("\t\t\tforeach(var v in value)");
                texts.Add("\t\t\t{");
                texts.Add("\t\t\t\tAdd(v);");
                texts.Add("\t\t\t}");
                texts.Add("\t\t}");
                texts.AddRange(DataSet.GetImplicitText(Name, cSharpText));
                texts.Add("\t\tpublic override string GetIFCText(bool includeClassName)");
                texts.Add("\t\t{");
                texts.Add("\t\t\tstring text = includeClassName ? \"" + GetType().Name.ToUpper() + "(\" : \"(\";");
                texts.Add("\t\t\tint n = Count;");
                texts.Add("\t\t\tfor(int i = 0; i < n; i++)");
                texts.Add("\t\t\t{");


                if (selects.FirstOrDefault(e => e.Name == parentName) != null)
                {
                    texts.Add("\t\t\t\ttext += this[i].GetIFCText(true) + (i < (n - 1) ? \",\": \")\");");
                }
                else
                {
                    texts.Add("\t\t\t\ttext += this[i].GetIFCText(false) + (i < (n - 1) ? \",\": \")\");");
                }

               
                texts.Add("\t\t\t}");
                texts.Add("\t\t\treturn text;");
                texts.Add("\t\t}");
            }
           
            texts.Add("\t}");

            return texts;
        }

        /// <summary>
        /// Get C# type name
        /// </summary>
        /// <returns></returns>
        public override string GetCSharpType()
        {
            if (DataSet.CSharpBasicDataTypes.ContainsKey(ParentName))
            {
                return "List<" + DataSet.CSharpBasicDataTypes[ParentName] + ">";
            }
            else
            {
                var parent = DataSet.BasicTypes.FirstOrDefault(e=>e.Name == ParentName);
                if (parent != null)
                {
                    return "List<" + parent.GetCSharpType() +">";
                }
                return "";
            }

        }
    }
}
