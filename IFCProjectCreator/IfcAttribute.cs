using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public abstract class IFCAttribute
    {
        public IFCListType ListType { get; set; }
        public IFCAttributeType AttributeType { get; set; }
        public IFCAggregation Aggregation { get; set; }
        public string Name { get; set; }
        public string TypeName { get; set; }

        public bool isReadOnly { get; set; }
        public bool isOverride { get; set; }
        public IFCDataSet? Dataset { get; set; }

        public bool includedInGLOBAL { get; set; }

        public IFCAttribute()
        {
            Name = "";
            TypeName = "";
            ListType = IFCListType.SINGLE;
            isReadOnly = false;
            Aggregation = IFCAggregation.NONE;
            AttributeType = IFCAttributeType.NONE;
            isOverride = false;
            includedInGLOBAL = false;

        }
        /// <summary>
        /// for compare attribute
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public bool isSameAttribute(IFCAttribute attribute)
        {
            return Name == attribute.Name && TypeName == attribute.TypeName && ListType == attribute.ListType && Aggregation == attribute.Aggregation;
        }

        public override string ToString()
        {
            string aggregationText = "";
            switch (ListType)
            {
                case IFCListType.SINGLE:
                    aggregationText = "";
                    break;
                case IFCListType.LIST:
                    aggregationText = ListType.ToString() + " ";
                    break;
                case IFCListType.LISTLIST:
                    aggregationText = ListType.ToString() + " ";
                    break;
            }
            return Name + " : " + aggregationText + TypeName;
        }

        public abstract List<string> GetCSharpText();
        public virtual List<string> GetCSharpGLOBALText(IFCDataSet dataSet)
        {
            string GLOBAL = dataSet.GLOBALName;
            string GLOBALTypeName = TypeName;
            string typeName = TypeName;
            string overideText = isOverride ? "override " : "virtual ";
            string listName = GetListName();
            if (!dataSet.CSharpBasicDataTypes.ContainsKey(TypeName))
            {
                GLOBALTypeName = GLOBAL + "." + TypeName;
            }
            else
            {
                typeName = "IFC_" + typeName;
                GLOBALTypeName = "IFC_" + GLOBALTypeName;
            }



            if (ListType == IFCListType.SINGLE)
            {
                if (this is IFCDerivedAttribute || this is IFCInverseAttribute || isReadOnly)
                {
                    return new List<string>
                    {
                        "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,GLOBAL) + "?" + " _" + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\treturn " + Name +";",
                        "\t\t\t}",
                        "\t\t}",
                    };
                }
                else
                {
                    return new List<string>
                    {
                        "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,GLOBAL) + "?" + " _" + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\treturn " + Name +";",
                        "\t\t\t}",
                        "\t\t\tset",
                        "\t\t\t{",
                        "\t\t\t\tif(value is " + typeName + " val)",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + Name + " = val;",
                        "\t\t\t\t}",
                        "\t\t\t\telse if(value == null)",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + Name + " = null;",
                        "\t\t\t\t}",
                        "\t\t\t}",
                        "\t\t}",
                    };
                }
            }
            else if (ListType == IFCListType.LIST)
            {
                if (this is IFCDerivedAttribute || this is IFCInverseAttribute || isReadOnly)
                {
                    List<string> texts = new List<string>()
                    {
                        "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,GLOBAL) + "?" + " _" + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\tif(" + Name + " != null)",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + listName + "<"+GLOBALTypeName + ">? _Items_ = new " + listName  +"<"+GLOBALTypeName +">();",
                        "\t\t\t\t\tforeach (" + typeName + " item in " + Name +")",
                        "\t\t\t\t\t{",
                        "\t\t\t\t\t\t_Items_.Add(item);",
                        "\t\t\t\t\t}",
                        "\t\t\t\t\treturn _Items_;",
                        "\t\t\t\t}",
                        "\t\t\t\treturn null;",
                        "\t\t\t}",
                        "\t\t}",
                    };
                    return texts;
                }
                else
                {
                    List<string> texts = new List<string>()
                    {
                        "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,GLOBAL) + "?" + " _" + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\tif(" + Name + " != null)",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + listName + "<"+GLOBALTypeName + ">? _Items_ = new " + listName+ "<"+GLOBALTypeName +">();",
                        "\t\t\t\t\tforeach (" + typeName + " item in " + Name +")",
                        "\t\t\t\t\t{",
                        "\t\t\t\t\t\t_Items_.Add(item);",
                        "\t\t\t\t\t}",
                        "\t\t\t\t\treturn _Items_;",
                        "\t\t\t\t}",
                        "\t\t\t\treturn null;",
                        "\t\t\t}",
                        "\t\t\tset",
                        "\t\t\t{",
                        "\t\t\t\tif(value == null)",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + Name + " = null;",
                        "\t\t\t\t}",
                        "\t\t\t\telse",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + Name + " = new " + listName+ "<" + typeName + ">();",
                        "\t\t\t\t\tforeach(var val in value)",
                        "\t\t\t\t\t{",
                        "\t\t\t\t\t\tif(val is " + typeName + " v)",
                        "\t\t\t\t\t\t{",
                        "\t\t\t\t\t\t\t" + Name + ".Add(v);",
                        "\t\t\t\t\t\t}",
                        "\t\t\t\t\t}",
                        "\t\t\t\t}",
                        "\t\t\t}",
                        "\t\t}",
                    };
                    return texts;
                }
            }
            else
            {
                if (this is IFCDerivedAttribute || this is IFCInverseAttribute || isReadOnly)
                {
                    List<string> texts = new List<string>()
                    {
                        "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,GLOBAL) + "?" + " _" + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\tif(" + Name + " != null)",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + listName + "<" + listName+ "<"+GLOBALTypeName + ">>? _Items_ = new " + listName+ "<" + listName+ "<"+GLOBALTypeName +">>();",
                        "\t\t\t\t\tforeach (" + listName+ "<" + typeName + "> item1s in " + Name +")",
                        "\t\t\t\t\t{",
                        "\t\t\t\t\t\t" + listName+ "<"+GLOBALTypeName + ">? resultItems = new " + listName+ "<"+GLOBALTypeName +">();",
                        "\t\t\t\t\t\tforeach (" + typeName + " item in item1s)",
                        "\t\t\t\t\t\t{",
                        "\t\t\t\t\t\t\tresultItems.Add(item);",
                        "\t\t\t\t\t\t}",
                        "\t\t\t\t\t\t_Items_.Add(resultItems);",
                        "\t\t\t\t\t}",
                        "\t\t\t\t\treturn _Items_;",
                        "\t\t\t\t}",
                        "\t\t\t\treturn null;",
                        "\t\t\t}",
                        "\t\t}",
                    };
                    return texts;
                }
                else
                {
                    List<string> texts = new List<string>()
                    {
                        "\t\tpublic " + overideText + GetCSharpTypeText(dataSet,GLOBAL) + "?" + " _" + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\tif(" + Name + " != null)",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + listName + "<" + listName + "<"+GLOBALTypeName + ">>? _Items_ = new " + listName + "<" + listName + "<"+GLOBALTypeName +">>();",
                        "\t\t\t\t\tforeach (" + listName + "<" + typeName + "> item1s in " + Name +")",
                        "\t\t\t\t\t{",
                        "\t\t\t\t\t\t" + listName + "<"+GLOBALTypeName + ">? resultItems = new " + listName + "<"+GLOBALTypeName +">();",
                        "\t\t\t\t\t\tforeach (" + typeName + " item in item1s)",
                        "\t\t\t\t\t\t{",
                        "\t\t\t\t\t\t\tresultItems.Add(item);",
                        "\t\t\t\t\t\t}",
                        "\t\t\t\t\t\t_Items_.Add(resultItems);",
                        "\t\t\t\t\t}",
                        "\t\t\t\t\treturn _Items_;",
                        "\t\t\t\t}",
                        "\t\t\t\treturn null;",
                        "\t\t\t}",
                        "\t\t\tset",
                        "\t\t\t{",
                        "\t\t\t\tif(value == null)",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + Name + " = null;",
                        "\t\t\t\t}",
                        "\t\t\t\telse",
                        "\t\t\t\t{",
                        "\t\t\t\t\t" + Name + " = new " + listName + "<" + listName + "<" + typeName + ">>();",
                        "\t\t\t\t\tforeach(var vals in value)",
                        "\t\t\t\t\t{",
                        "\t\t\t\t\t\tif(vals != null)",
                        "\t\t\t\t\t\t{",
                        "\t\t\t\t\t\t\t" + listName + "<" + typeName + "> _Items_ = new " + listName + "<" + typeName + ">();",
                        "\t\t\t\t\t\t\tforeach(var val in vals)",
                        "\t\t\t\t\t\t\t{",
                        "\t\t\t\t\t\t\t\tif(val is " + typeName + " v)",
                        "\t\t\t\t\t\t\t\t{",
                        "\t\t\t\t\t\t\t\t\t_Items_.Add(v);",
                        "\t\t\t\t\t\t\t\t}",
                        "\t\t\t\t\t\t\t}",
                        "\t\t\t\t\t\t\t" + Name + ".Add(_Items_);",
                        "\t\t\t\t\t\t}",
                        "\t\t\t\t\t}",
                        "\t\t\t\t}",
                        "\t\t\t}",
                        "\t\t}",
                    };
                    return texts;
                }
            }
        }


        public virtual string GetCSharpTypeText()
        {
            string listName = GetListName();
            string typeName = TypeName;
            if(Dataset != null && Dataset.CSharpBasicDataTypes.ContainsKey(typeName))
            {
                typeName = "IFC_" + typeName;
            }
            switch (ListType)
            {
                case IFCListType.SINGLE:
                    return typeName;
                case IFCListType.LIST:
                    return listName + "<" + typeName + ">";
                case IFCListType.LISTLIST:
                    return listName + "<" + listName + "<" + typeName + ">>"; ;
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
            string listName = GetListName();
            switch (ListType)
            {
                case IFCListType.SINGLE:
                    return typeName;
                case IFCListType.LIST:
                    return listName + "<" + typeName + ">";
                case IFCListType.LISTLIST:
                    return listName + "<" + listName + "<" + typeName + ">>";
            }
            return TypeName;
        }
        public string GetListName()
        {
            return "IFC_" + Aggregation.ToString();
        }
    }

    

    public enum IFCListType
    {
        SINGLE,
        LIST,
        LISTLIST
    }

    public enum IFCAttributeType
    {
        ENTITY,
        SELECT,
        SIMPLE,
        SIMPLELIST,
        ENUM,
        NONE
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
