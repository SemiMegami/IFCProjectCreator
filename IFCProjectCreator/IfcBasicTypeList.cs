using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IfcBasicTypeList : IfcBasicType
    {
        public IfcBasicTypeList(IfcDataSet dataSet, string version) : base(dataSet, version)
        {
        }

       

        public override List<string> ToCShapText()
        {
            throw new NotImplementedException();
        }

    }
}
