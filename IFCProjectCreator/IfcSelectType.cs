using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IfcSelectType : IfcBase
    {
        public List<IfcAttribute> Attributes;

        public IfcSelectType(IfcDataSet dataSet, string version) : base(dataSet, version)
        {
            Attributes = new List<IfcAttribute>();
        }
        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_TYPE;");
            for(int i = 1; i < EXPLines.Count - 1; i++)
            {
                SubClassesNames.Add(EXPLines[i].Replace("(","").Replace(")","").Replace("\t","").Replace(",","").Replace(";",""));
            }      
        }

        public override List<string> ToCShapText()
        {
            throw new NotImplementedException();
        }
    }
}
