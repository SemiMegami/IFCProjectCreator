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
            isReadonly = true;
            RelatedAttributeName = "";
        }

        public override List<string> GetCSharpText()
        {
            List<string> texts = new List<string>();
          
            if(RelatedAttribute != null)
            {
                if (AttributeType == IFCAttributeType.LIST)
                {
                    if (RelatedAttribute.AttributeType == IFCAttributeType.LIST)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " {get{return Model?.GetItems<" + TypeName + ">().Where(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + ".Contains(this)).ToList();}set{}}");
                    }
                    else if (RelatedAttribute.AttributeType == IFCAttributeType.SINGLE)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " {get{return Model?.GetItems<" + TypeName + ">().Where(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + " == this).ToList();} set{}}");
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (RelatedAttribute.AttributeType == IFCAttributeType.LIST)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " {get{return Model?.GetItems<" + TypeName + ">().FirstOrDefault(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + ".Contains(this));} set{}}");
                    }
                    else if (RelatedAttribute.AttributeType == IFCAttributeType.SINGLE)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " {get{return Model?.GetItems<" + TypeName + ">().FirstOrDefault(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + " == this);} set{}}");
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
