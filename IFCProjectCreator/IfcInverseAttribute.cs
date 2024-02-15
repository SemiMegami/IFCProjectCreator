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
           
            RelatedAttributeName = "";
        }

        public override List<string> GetCSharpText()
        {
            List<string> texts = new List<string>
            {
                "\t\t//TODO INVERSE",
            };
            if(RelatedAttribute != null)
            {
                if (AttributeType == IFCAttributeType.LIST)
                {
                    if (RelatedAttribute.AttributeType == IFCAttributeType.LIST)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " => Model?.GetItems<" + TypeName + ">().Where(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + ".Contains(this)).ToList();");
                    }
                    else if (RelatedAttribute.AttributeType == IFCAttributeType.SINGLE)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " => Model?.GetItems<" + TypeName + ">().Where(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + " == this).ToList();");
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (RelatedAttribute.AttributeType == IFCAttributeType.LIST)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " => Model?.GetItems<" + TypeName + ">().FirstOrDefault(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + ".Contains(this));");
                    }
                    else if (RelatedAttribute.AttributeType == IFCAttributeType.SINGLE)
                    {
                        texts.Add("\t\tpublic " + GetCSharpTypeText() + "? " + Name + " => Model?.GetItems<" + TypeName + ">().FirstOrDefault(x => x." + RelatedAttributeName + " != null && x." + RelatedAttributeName + " == this);");
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
