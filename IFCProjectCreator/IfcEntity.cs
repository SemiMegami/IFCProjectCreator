using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCEntity : IFCClass
    {
        public bool IsAbstract { get; set; }
        public List<IFCParameterAttribute> ParameterClassAttributes { get; set; }
        public List<IFCDeriveAttribute> DeriveAttributes { get; set; }
        public List<IFCInverseAttribute> InverseAttributes { get; set; }
        public List<IFCWhereAttribute> WhereAttributes { get; set; }
        public IFCEntity? ParentClass { get; set; }


        public IFCEntity(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            IsAbstract = false;
            ParameterClassAttributes = new List<IFCParameterAttribute>();
            DeriveAttributes = new List<IFCDeriveAttribute>();
            InverseAttributes = new List<IFCInverseAttribute>();
            WhereAttributes = new List<IFCWhereAttribute>();
        }

      
        List<IFCParameterAttribute> Attributes
        {
            get
            {
                List <IFCParameterAttribute> attributes = new List <IFCParameterAttribute> ();
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
                        IFCParameterAttribute IFCAttribute = new IFCParameterAttribute();
                        IFCAttribute.IsOptional = line.Contains("OPTIONAL");
                        SetAttributeType(IFCAttribute, line, nW);
                        ParameterClassAttributes.Add(IFCAttribute);
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
                        IFCDeriveAttribute IFCAttribute = new IFCDeriveAttribute();
                        IFCAttribute.DeriveText = line.Split(" := ")[1];
                        SetAttributeType(IFCAttribute, line, splitIndex);
                        DeriveAttributes.Add(IFCAttribute);
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
                        IFCInverseAttribute IFCAttribute = new IFCInverseAttribute();
                        SetAttributeType(IFCAttribute, line, splitIndex);
                        IFCAttribute.RelatedAttributeName = words[nW - 1].Replace(";", "");
                        InverseAttributes.Add(IFCAttribute);
                    }
                }
            }
        }


        private void SetAttributeType(IFCAttribute IFCAttribute, string line, int splitIndex)
        {

            string[] words = line.Replace("\t", "").Split(" ");

            IFCAttribute.Name = words[0];
            IFCAttribute.TypeName = words[splitIndex - 1].Replace(";","");
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
                    IFCAttribute.AttributeType = IFCAttributeType.SINGLE;
                    break;
                case 1:
                    IFCAttribute.AttributeType = IFCAttributeType.LIST;
                    break;
                case 2:
                    IFCAttribute.AttributeType = IFCAttributeType.LISTLIST;
                    break;
            }
            if (ofCount > 0)
            {
                if (line.Contains("ARRAY"))
                {
                    IFCAttribute.Aggregation = IFCAggregation.ARRAY;
                }
                if (line.Contains("BAG"))
                {
                    IFCAttribute.Aggregation = IFCAggregation.BAG;
                }
                if (line.Contains("LIST"))
                {
                    IFCAttribute.Aggregation = IFCAggregation.LIST;
                }
                if (line.Contains("SET"))
                {
                    IFCAttribute.Aggregation = IFCAggregation.SET;
                }
            }
        }
        public override List<string> GetCSharpTexts()
        {
            List<string> texts = GetCSharpSummaryTexts();
            texts.Add(GetCSharpHeaderText());
           
            // constructor
            texts.Add("\t{");
            foreach(var attribute in ParameterClassAttributes)
            {
                texts.AddRange(attribute.GetCSharpText());
            }
            texts.Add("\t}");

            return texts;
        }

        protected override string GetCSharpTypeText()
        {
            return IsAbstract ? "abstract class" : "class";
        }

    }
}
