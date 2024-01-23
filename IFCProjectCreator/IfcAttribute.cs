using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IfcAttribute
    {
        public IfcAttributeType AttributeType { get; set; }
        public IfcAggregation Aggregation { get; set; }
        public string Name { get; set; }
        public string TypeName { get; set; }


        public IfcAttribute()
        {
            AttributeType = IfcAttributeType.SINGLE;
            Aggregation = IfcAggregation.NONE;

        }

        public override string ToString()
        {
            string aggregationText = "";
            switch (AttributeType)
            {
                case IfcAttributeType.SINGLE:
                    aggregationText = "";
                    break;
                case IfcAttributeType.LIST:
                    aggregationText = AttributeType.ToString() + " ";
                    break;
                case IfcAttributeType.LISTLIST:
                    aggregationText = AttributeType.ToString() + " ";
                    break;
            }
            return Name + " : " + aggregationText + TypeName;
        }
    }

    public enum IfcAttributeType
    {
        SINGLE,
        LIST,
        LISTLIST
    }

    public enum IfcAggregation
    {
        NONE,
        ARRAY,
        BAG,
        LIST,
        SET
    }
}
