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
            List<string> texts = new List<string>();
            return texts;
        }

    }
}
