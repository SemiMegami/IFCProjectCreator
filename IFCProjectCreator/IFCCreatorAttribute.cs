using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCCreatorAttribute : IFCAttribute
    {
        public override List<string> GetCSharpText()
        {
            return new List<string>() 
            {
                "\t\tpublic virtual " + GetCSharpTypeText() + "? " + Name + " { get; set; }" 
            };
        }

        public override string GetCSharpTypeText()
        {
            switch (ListType)
            {
                case IFCListType.SINGLE:
                    return "C" + TypeName;
                case IFCListType.LIST:
                    return "List<C" + TypeName + ">";
                case IFCListType.LISTLIST:
                    return "List<List<C" + TypeName + ">>";
            }
            return TypeName;
        }
    }
}
