using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCBasicType : IFCClass
    {
        protected static Dictionary<string, string> CSharpDataTypes = new Dictionary<string, string>()
        {
            { "REAL", "double" },
            { "INTEGER", "int" },
            { "NUMBER", "double" },
            { "LOGICAL", "bool" },
            { "BOOLEAN", "bool" },
            { "BINARY", "int" },
            { "STRING", "string" },
        };
        public IFCBasicType? ParentClass { get; set; }
        public List<IFCWhereAttribute> WhereAttributes { get; set; }
        public IFCBasicType(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            WhereAttributes = new List<IFCWhereAttribute>();
        }
        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_TYPE;");
            string[] words = header.Split(" ");
            foreach (string word in words)
            {
                foreach (var key in CSharpDataTypes.Keys)
                {
                    if(word.Contains(key))
                    {
                        ParentName = key;
                    }
                }
            }
            if(ParentName == "")
            {
                ParentName = words[words.Length - 1].Replace(";", "");
                if (ParentName.Contains("STRING"))
                {
                    ParentName = "STRING";
                }
            }
        }

        public override List<string> GetCSharpTexts()
        {
            string cSharpText = GetCSharpType();
            List<string> texts = GetCSharpSummaryTexts();
            texts.Add(GetCSharpHeaderText());

            // constructor
            texts.Add("\t{");
            texts.Add("\t\t" + Name + "() { }");
            texts.Add("\t\t" + Name + "(" + cSharpText + " value) { Value = value; }");
            // implicit operator
            texts.Add("\t\tpublic static implicit operator " + Name + "(" + cSharpText + " value) { return new " + Name +"(" + cSharpText +");}");
            texts.Add("\t\tpublic static implicit operator " + cSharpText + "(" + Name + " value) { return value.Value;}");

            texts.Add("\t}");

            return texts;
        }

        /// <summary>
        /// Get C# type name
        /// </summary>
        /// <returns></returns>
        protected string GetCSharpType()
        {
            if (ParentClass == null)
            {
                return CSharpDataTypes[ParentName];
            }
            else
            {
                return ParentClass.GetCSharpType();
            }
        }

       
    }
}
