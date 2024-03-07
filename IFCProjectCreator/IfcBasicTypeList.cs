using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCBasicTypeList : IFCBasicType
    {
        public IFCBasicTypeList(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
        }

        public override List<string> GetCSharpTexts()
        {
            string cSharpText = GetCSharpType();
            List<string> texts = GetCSharpSummaryTexts();
            texts.Add("\tpublic class " + Name + " : IFC_Attributes<" + ParentName + ">" + ", " + DataSet.globalName + "." + Name);
            texts.Add("\t{");

            if(cSharpText.Length > 0)
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
