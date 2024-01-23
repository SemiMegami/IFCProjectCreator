using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IfcBasicType : IfcBase
    {
        public IfcBasicType ParentClass;

        public IfcBasicType(IfcDataSet dataSet, string version) : base(dataSet, version)
        {
        }
        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_TYPE;");
            string[] words = header.Split(" ");
            ParentName = words[words.Length - 1].Replace(";","");
        }

        public override List<string> ToCShapText()
        {
            throw new NotImplementedException();
        }
    }
}
