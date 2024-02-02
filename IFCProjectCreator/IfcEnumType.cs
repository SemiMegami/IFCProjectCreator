using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCEnumType : IFCClass
    {
        public List<string> EnumValues { get; set; }
        public IFCEnumType(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            EnumValues = new List<string>();
        }
        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_TYPE;");
            for (int i = 1; i < EXPLines.Count - 1; i++)
            {
                EnumValues.Add(EXPLines[i].Replace("(", "").Replace(")", "").Replace("\t", "").Replace(",", "").Replace(";", ""));
            }
        }

        public override List<string> GetCSharpTexts()
        {
            List<string> texts = new List<string>();
            return texts;
        }
    }
}
