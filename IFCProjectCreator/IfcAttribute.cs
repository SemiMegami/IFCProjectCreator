using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public abstract class IFCAttribute
    {
        public IFCAttributeType AttributeType { get; set; }
        public IFCAggregation Aggregation { get; set; }
        public string Name { get; set; }
        public string TypeName { get; set; }


        public IFCAttribute()
        {
            Name = "";
            TypeName = "";
            AttributeType = IFCAttributeType.SINGLE;
            Aggregation = IFCAggregation.NONE;
        }

        public override string ToString()
        {
            string aggregationText = "";
            switch (AttributeType)
            {
                case IFCAttributeType.SINGLE:
                    aggregationText = "";
                    break;
                case IFCAttributeType.LIST:
                    aggregationText = AttributeType.ToString() + " ";
                    break;
                case IFCAttributeType.LISTLIST:
                    aggregationText = AttributeType.ToString() + " ";
                    break;
            }
            return Name + " : " + aggregationText + TypeName;
        }

        public abstract List<string> GetCSharpText();

        public string GetCSharpTypeText()
        {
            switch (AttributeType)
            {
                case IFCAttributeType.SINGLE:
                    return TypeName;
                case IFCAttributeType.LIST:
                    return "List<" + TypeName + ">";
                case IFCAttributeType.LISTLIST:
                    return"List<List<" + TypeName + " >>";
            }
            return TypeName;
        }
    }

    public enum IFCAttributeType
    {
        SINGLE,
        LIST,
        LISTLIST
    }

    public enum IFCAggregation
    {
        NONE,
        ARRAY,
        BAG,
        LIST,
        SET
    }
}
