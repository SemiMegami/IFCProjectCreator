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
            switch (AttributeType)
            {
                case IFCAttributeType.SINGLE:
                    return "C" + TypeName;
                case IFCAttributeType.LIST:
                    return "List<C" + TypeName + ">";
                case IFCAttributeType.LISTLIST:
                    return "List<List<C" + TypeName + ">>";
            }
            return TypeName;
        }
    }
}
