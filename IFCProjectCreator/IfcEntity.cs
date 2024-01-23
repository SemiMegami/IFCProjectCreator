using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IfcEntity : IfcBase
    {
        public bool IsAbstract;
        public List<ParameterAttribute> ParameterClassAttributes;
        public List<IfcDeriveAttribute> DeriveAttributes;
        public List<IfcInverseAttribute> InverseAttributes;
        public IfcEntity ParentClass;


        public IfcEntity(IfcDataSet dataSet, string version) : base(dataSet, version)
        {
            IsAbstract = false;
            ParameterClassAttributes = new List<ParameterAttribute>();
            DeriveAttributes = new List<IfcDeriveAttribute>();
            InverseAttributes = new List<IfcInverseAttribute>();
        }

      
        List<ParameterAttribute> Attributes
        {
            get
            {
                List <ParameterAttribute> attributes = new List <ParameterAttribute> ();
                if (ParentClass != null)
                {
                    attributes.AddRange(ParentClass.Attributes);
                }
                attributes.AddRange(ParameterClassAttributes);
                return attributes;
            }
        }

        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_ENTITY;");
            string AttributeType = "";
            
            foreach (string line in EXPLines)
            {
                string[] words = line.Replace("\t","").Split(" ");
                int nW = words.Length;
                // find parent class
                if (line.Contains("SUBTYPE OF"))
                {
                  
                    ParentName = words[nW - 1].Replace(";", "").Replace("(", "").Replace(")", "");
                }

                // Set Abstract
                if (line.Contains("ABSTRACT"))
                {
                    IsAbstract = true;
                }

                // Set reading mode
                if (line.Contains("INVERSE") || line.Contains("DERIVE") || line.Contains("WHERE") || line.Contains("UNIQUE"))
                {
                    AttributeType = line.Replace(" ", "");
                }

                // Read Attributes

                if (line.Contains(':'))
                {
                    if (AttributeType == "")
                    {
                        ParameterAttribute ifcAttribute = new ParameterAttribute();
                        ifcAttribute.IsOptional = line.Contains("OPTIONAL");
                        SetAttributeType(ifcAttribute, line, nW);
                        ParameterClassAttributes.Add(ifcAttribute);
                    }
                    else if (AttributeType == "DERIVE")
                    {
                        int splitIndex = -1;
                        for (int i = 0; i < nW; i++)
                        {
                            if (words[i] == ":=")
                            {
                                splitIndex = i;
                            }
                        }
                        IfcDeriveAttribute ifcAttribute = new IfcDeriveAttribute();
                        ifcAttribute.DeriveText = line.Split(" := ")[1];
                        SetAttributeType(ifcAttribute, line, splitIndex);
                        DeriveAttributes.Add(ifcAttribute);
                    }
                    else if (AttributeType == "INVERSE")
                    {
                        int splitIndex = -1;
                        for (int i = 0; i < nW; i++)
                        {
                            if (words[i] == "FOR")
                            {
                                splitIndex = i;
                            }
                        }
                        IfcInverseAttribute ifcAttribute = new IfcInverseAttribute();
                        SetAttributeType(ifcAttribute, line, splitIndex);
                        ifcAttribute.RelatedAttributeName = words[nW - 1].Replace(";", "");
                        InverseAttributes.Add(ifcAttribute);
                    }
                }
            }
        }


        private void SetAttributeType(IfcAttribute ifcAttribute, string line, int splitIndex)
        {

            string[] words = line.Replace("\t", "").Split(" ");

            ifcAttribute.Name = words[0];
            ifcAttribute.TypeName = words[splitIndex - 1].Replace(";","");
            int ofCount = 0;

            for (int i = 0; i < splitIndex; i++)
            {
                if (words[i] == "OF")
                {
                    ofCount++;
                }
            }

            switch (ofCount)
            {
                case 0:
                    ifcAttribute.AttributeType = IfcAttributeType.SINGLE;
                    break;
                case 1:
                    ifcAttribute.AttributeType = IfcAttributeType.LIST;
                    break;
                case 2:
                    ifcAttribute.AttributeType = IfcAttributeType.LISTLIST;
                    break;
            }
            if (ofCount > 0)
            {
                if (line.Contains("ARRAY"))
                {
                    ifcAttribute.Aggregation = IfcAggregation.ARRAY;
                }
                if (line.Contains("BAG"))
                {
                    ifcAttribute.Aggregation = IfcAggregation.BAG;
                }
                if (line.Contains("LIST"))
                {
                    ifcAttribute.Aggregation = IfcAggregation.LIST;
                }
                if (line.Contains("SET"))
                {
                    ifcAttribute.Aggregation = IfcAggregation.SET;
                }
            }
        }
        public override List<string> ToCShapText()
        {
            throw new NotImplementedException();
        }

       
    }
}
