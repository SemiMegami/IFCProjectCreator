using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCInverseAttribute: IFCAttribute
    {
        public string RelatedAttributeName { get; set; }
        public IFCParameterAttribute? RelatedAttribute{ get; set; }
        public IFCInverseAttribute() :base() 
        {
            isReadOnly = true;
            RelatedAttributeName = "";
        }

        public override List<string> GetCSharpText()
        {
            List<string> texts = new List<string>();
          
            if(RelatedAttribute != null)
            {
                if (ListType == IFCListType.LIST)
                {
                    if (RelatedAttribute.ListType == IFCListType.LIST)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " {get{return new IFC_Attributes<" + TypeName + ">(Model?.GetItems<" + TypeName + ">().Where(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + ".Contains(this)).ToList());}}");
                    }
                    else if (RelatedAttribute.ListType == IFCListType.SINGLE)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " {get{return new IFC_Attributes<" + TypeName + ">(Model?.GetItems<" + TypeName + ">().Where(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + " == this).ToList());}}");
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (RelatedAttribute.ListType == IFCListType.LIST)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " {get{return Model?.GetItems<" + TypeName + ">().FirstOrDefault(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + ".Contains(this));}}");
                    }
                    else if (RelatedAttribute.ListType == IFCListType.SINGLE)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " {get{return Model?.GetItems<" + TypeName + ">().FirstOrDefault(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + " == this);}}");
                    }
                    else
                    {

                    }
                }
            }

            return texts;
        }
    }
}
