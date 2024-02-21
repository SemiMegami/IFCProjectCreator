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

        public bool isReadonly { get; set; }
        public bool isOverride { get; set; }

        public bool includedInGlobal { get; set; }
        public IFCAttribute()
        {
            Name = "";
            TypeName = "";
            AttributeType = IFCAttributeType.SINGLE;
            isReadonly = false;
            Aggregation = IFCAggregation.NONE;
            isOverride = false;
            includedInGlobal = false;
        }
        /// <summary>
        /// for compare attribute
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public bool isSameAttribute(IFCAttribute attribute)
        {
            return Name == attribute.Name && TypeName == attribute.TypeName && AttributeType == attribute.AttributeType && Aggregation == attribute.Aggregation;
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
        public virtual List<string> GetCSharpGlobalText(IFCDataSet dataSet)
        {
            string global = "Global";
            string typeName = TypeName;
            string overideText = isOverride ? "override " : "virtual ";
         
             if (!dataSet.CSharpBasicDataTypes.ContainsKey(TypeName))
            {
                typeName = global + "." + TypeName;
            }

            if (AttributeType == IFCAttributeType.SINGLE)
            {
                if (this is IFCDeriveAttribute || this is IFCInverseAttribute)
                {
                    return new List<string>
                    {
                        "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,global) + "?" + " _" + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\treturn " + Name +";",
                        "\t\t\t}",
                        "\t\t\tset",
                        "\t\t\t{",
                        "\t\t\t}",
                        "\t\t}",
                    };
                }
                else
                {
                    return new List<string>
                    {
                        "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,global) + "?" + " _" + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\treturn " + Name +";",
                        "\t\t\t}",
                        "\t\t\tset",
                        "\t\t\t{",
                        "\t\t\t\tif(value is " + TypeName + " val)",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + Name + " = val;",
                        "\t\t\t\t}",
                        "\t\t\t}",
                        "\t\t}",
                    };
                }
               
            }
            else if (AttributeType == IFCAttributeType.LIST)
            {
                if (isReadonly)
                {
                    List<string> texts = new List<string>()
                    {
                        "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,global) + "?" + " _" + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\tif(" + Name + " != null)",
                        "\t\t\t\t{",
                        "\t\t\t\t\tList<"+typeName + ">? items = new List<"+typeName +">();",
                        "\t\t\t\t\tforeach (" + TypeName + " item in " + Name +")",
                        "\t\t\t\t\t{",
                        "\t\t\t\t\t\titems.Add(item);",
                        "\t\t\t\t\t}",
                        "\t\t\t\t\treturn items;",
                        "\t\t\t\t}",
                        "\t\t\t\treturn null;",
                        "\t\t\t}",
                        "\t\t\tset",
                        "\t\t\t{",
                        "\t\t\t}",
                        "\t\t}",
                    };
                    return texts;
                }
                else
                {
                    List<string> texts = new List<string>()
                    {
                        "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,global) + "?" + " _" + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\tif(" + Name + " != null)",
                        "\t\t\t\t{",
                        "\t\t\t\t\tList<"+typeName + ">? items = new List<"+typeName +">();",
                        "\t\t\t\t\tforeach (" + TypeName + " item in " + Name +")",
                        "\t\t\t\t\t{",
                        "\t\t\t\t\t\titems.Add(item);",
                        "\t\t\t\t\t}",
                        "\t\t\t\t\treturn items;",
                        "\t\t\t\t}",
                        "\t\t\t\treturn null;",
                        "\t\t\t}",
                        "\t\t\tset",
                        "\t\t\t{",
                        "\t\t\t}",
                        "\t\t}",
                    };
                    return texts;
                }
                
            }
            else
            {
                List<string> texts = new List<string>()
                {
                   "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,global) + "?" + " _" + Name,
                    "\t\t{",
                    "\t\t\tget",
                    "\t\t\t{",
                    "\t\t\t\tif(" + Name + " != null)",
                    "\t\t\t\t{",
                    "\t\t\t\t\tList<List<"+typeName + ">>? items = new List<List<"+typeName +">>();",
                    "\t\t\t\t\tforeach (List<" + TypeName + "> item1s in " + Name +")",
                    "\t\t\t\t\t{",
                    "\t\t\t\t\t\tList<"+typeName + ">? resultItems = new List<"+typeName +">();",
                    "\t\t\t\t\t\tforeach (" + TypeName + " item in item1s)",
                    "\t\t\t\t\t\t{",
                    "\t\t\t\t\t\t\tresultItems.Add(item);",
                    "\t\t\t\t\t\t}",
                    "\t\t\t\t\t\titems.Add(resultItems);",
                    "\t\t\t\t\t}",
                    "\t\t\t\t\treturn items;",
                    "\t\t\t\t}",
                    "\t\t\t\treturn null;",
                    "\t\t\t}",
                    "\t\t\tset",
                    "\t\t\t{",
                    "\t\t\t}",
                    "\t\t}",
                };
                return texts;
            }
        }


        public virtual string GetCSharpTypeText()
        {
            switch (AttributeType)
            {
                case IFCAttributeType.SINGLE:
                    return TypeName;
                case IFCAttributeType.LIST:
                    return "List<" + TypeName + ">";
                case IFCAttributeType.LISTLIST:
                    return"List<List<" + TypeName + ">>";
            }
            return TypeName;
        }

        public string GetCSharpTypeText(IFCDataSet dataSet, string interfaceName)
        {
            if (dataSet.CSharpBasicDataTypes.ContainsKey(TypeName))
            {
                return GetCSharpTypeText();
            }

            string typeName = interfaceName + "." + TypeName;
            switch (AttributeType)
            {
                case IFCAttributeType.SINGLE:
                    return typeName;
                case IFCAttributeType.LIST:
                    return "List<" + typeName + ">";
                case IFCAttributeType.LISTLIST:
                    return "List<List<" + typeName + ">>";
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
