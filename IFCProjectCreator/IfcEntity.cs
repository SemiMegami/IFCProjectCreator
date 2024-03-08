using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IFCProjectCreator
{
    public class IFCEntity : IFCClass
    {
        public bool IsAbstract { get; set; }
        public List<IFCParameterAttribute> ParameterClassAttributes { get; set; }
        public List<IFCDerivedAttribute> DeriveClassAttributes { get; set; }
        public List<IFCInverseAttribute> InverseClassAttributes { get; set; }
        public List<IFCWhereAttribute> WhereClassAttributes { get; set; }
        public IFCEntity? ParentClass { get; set; }


        public IFCEntity(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            IsAbstract = false;
            ParameterClassAttributes = new List<IFCParameterAttribute>();
            DeriveClassAttributes = new List<IFCDerivedAttribute>();
            InverseClassAttributes = new List<IFCInverseAttribute>();
            WhereClassAttributes = new List<IFCWhereAttribute>();
        }


        /// <summary>
        /// ParameterClassAttributes including from parent
        /// </summary>
        public List<IFCAttribute> AllAttributes
        {
            get
            {
                Dictionary<string, IFCAttribute> attributes = new Dictionary<string, IFCAttribute>();
                if(ParentClass != null)
                {
                    List<IFCAttribute> parentAttributes = ParentClass.AllAttributes;
                    foreach(IFCAttribute attribute in parentAttributes)
                    {
                        attributes.Add(attribute.Name, attribute);
                    }              
                }
                List<IFCAttribute> classAttributes = AllClassAttributes;
                foreach (IFCAttribute attribute in classAttributes)
                {
                    if (!attributes.ContainsKey(attribute.Name))
                    {
                        attributes.Add(attribute.Name, attribute);
                    }
                }
                return attributes.Values.ToList();
            }
        }

        /// <summary>
        /// ParameterClassAttributes including from parent
        /// </summary>
        public List<IFCAttribute> AllClassAttributes
        {
            get
            {

                Dictionary<string, IFCAttribute> attributes = new Dictionary<string, IFCAttribute>();

                foreach (IFCAttribute attribute in ParameterClassAttributes)
                {
                    if (!attributes.ContainsKey(attribute.Name))
                    {
                        attributes.Add(attribute.Name, attribute);
                    }
                }
                foreach (IFCAttribute attribute in DeriveClassAttributes)
                {
                    if (!attributes.ContainsKey(attribute.Name))
                    {
                        attributes.Add(attribute.Name, attribute);
                    }
                }
                foreach (IFCAttribute attribute in InverseClassAttributes)
                {
                    if (!attributes.ContainsKey(attribute.Name))
                    {
                        attributes.Add(attribute.Name, attribute);
                    }
                }
                return attributes.Values.ToList();
            }
        }

        /// <summary>
        /// ParameterClassAttributes including from parent
        /// </summary>
        public List<IFCParameterAttribute> DirectAttributes
        {
            get
            {
                List<IFCParameterAttribute> attributes = new List<IFCParameterAttribute>();
                if (ParentClass != null)
                {
                    attributes.AddRange(ParentClass.DirectAttributes);
                }
                attributes.AddRange(ParameterClassAttributes);
                return attributes;
            }
        }

        /// <summary>
        /// ParameterClassAttributes including from parent
        /// </summary>
        public List<IFCParameterAttribute> ParentsDirectAttributes
        {
            get
            {
                List<IFCParameterAttribute> attributes = new List<IFCParameterAttribute>();
                if (ParentClass != null)
                {
                    attributes.AddRange(ParentClass.DirectAttributes);
                }
                return attributes;
            }
        }

        /// <summary>
        /// ParameterClassAttributes including from parent
        /// </summary>
        public List<IFCDerivedAttribute> DerivedAttributes
        {
            get
            {
                List<IFCDerivedAttribute> attributes = new List<IFCDerivedAttribute>();
                if (ParentClass != null)
                {
                    attributes.AddRange(ParentClass.DerivedAttributes);
                }
                attributes.AddRange(DeriveClassAttributes);
                return attributes;
            }
        }

        /// <summary>
        /// ParameterClassAttributes including from parent
        /// </summary>
        public List<IFCInverseAttribute> InverseAttributes
        {
            get
            {
                List<IFCInverseAttribute> attributes = new List<IFCInverseAttribute>();
                if (ParentClass != null)
                {
                    attributes.AddRange(ParentClass.InverseAttributes);
                }
                attributes.AddRange(InverseClassAttributes);
                return attributes;
            }
        }

        /// <summary>
        /// ParameterClassAttributes including from parent
        /// </summary>
        public List<IFCWhereAttribute> WhereAttributes
        {
            get
            {
                List<IFCWhereAttribute> attributes = new List<IFCWhereAttribute>();
                if (ParentClass != null)
                {
                    attributes.AddRange(ParentClass.WhereAttributes);
                }
                attributes.AddRange(WhereClassAttributes);
                return attributes;
            }
        }

        /// <summary>
        /// Parent Classes
        /// </summary>
        public List<IFCEntity> ParentClasses
        {
            get
            {
                if (ParentClass == null)
                {
                    return new List<IFCEntity>();
                }
                List<IFCEntity> classes = ParentClass.ParentClasses;
                classes.Add(ParentClass);
                return classes;
            }
        }

   


        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_ENTITY;");
            string attributeType = "";
            
            foreach (string line in EXPLines)
            {
                string[] words = line.Replace("\t","").Split(" ");
                int nW = words.Length;
                // find parent class
                if (line.Contains("SUBTYPE OF"))
                {
                    ParentName = words[nW - 1].Replace(";", "").Replace("(", "").Replace(")", "");
                    ParentName = ParentName.Replace("Ifc", "IFC");
                }
                // Set Abstract
                if (line.Contains("ABSTRACT"))
                {
                    IsAbstract = true;
                }
                // Set reading mode
                if (line.Contains("INVERSE") || line.Contains("DERIVE") || line.Contains("WHERE") || line.Contains("UNIQUE"))
                {
                    string attType = line.Replace(" ", "");
                    if(attType == "INVERSE" || attType == "DERIVE" || attType == "WHERE" || attType == "UNIQUE")
                    {
                        attributeType = attType.Replace(" ", "");
                    }
                    
                }
          
                if (line.Contains(':'))
                {
                    if (attributeType == "")
                    {
                        IFCParameterAttribute IFCAttribute = new IFCParameterAttribute();
                        IFCAttribute.IsOptional = line.Contains("OPTIONAL");
                        SetAttributeType(IFCAttribute, line, nW);
                        ParameterClassAttributes.Add(IFCAttribute);
                    }
                    else if (attributeType == "DERIVE")
                    {
                        int splitIndex = -1;
                        for (int i = 0; i < nW; i++)
                        {
                            if (words[i] == ":=")
                            {
                                splitIndex = i;
                            }
                        }
                        IFCDerivedAttribute IFCAttribute = new IFCDerivedAttribute() { Entity = this };
                        string[] strings = line.Split(" := ");
                        if(strings.Length > 1)
                        {
                            IFCAttribute.DeriveText = line.Split(" := ")[1];
                        }
                        else
                        {
                            IFCAttribute.DeriveText = reader.ReadLine()?? "";
                        }
                        SetAttributeType(IFCAttribute, line, splitIndex);
                        DeriveClassAttributes.Add(IFCAttribute);
                    }
                    else if (attributeType == "INVERSE")
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
                        InverseClassAttributes.Add(IFCAttribute);
                    }
                    else if(attributeType == "WHERE")
                    {
                        IFCWhereAttribute IFCAttribute = new IFCWhereAttribute();
                        IFCAttribute.Name = "WR_" + words[0].Replace(" ", "");
                        IFCAttribute.Entity = this;
                        WhereClassAttributes.Add(IFCAttribute);
                    }
                }
            }
        }


        private void SetAttributeType(IFCAttribute attribute, string line, int splitIndex)
        {

            string[] words = line.Replace("\t", "").Split(" ");

            // coorect attribute name
            attribute.Name = words[0];
            if (attribute.Name.Contains("."))
            {
                string[] splitedName = attribute.Name.Split(".");
                attribute.Name = splitedName[splitedName.Length - 1];
            }

            // correct attibute type name
            attribute.TypeName = words[splitIndex - 1].Replace(";","");
            if( attribute.TypeName == "BINARY(32)")
            {
                attribute.TypeName = "BINARY";
            }
            attribute.TypeName = attribute.TypeName.Replace("Ifc", "IFC");
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
                    attribute.AttributeType = IFCAttributeType.SINGLE;
                    break;
                case 1:
                    attribute.AttributeType = IFCAttributeType.LIST;
                    break;
                case 2:
                    attribute.AttributeType = IFCAttributeType.LISTLIST;
                    break;
            }
            if (ofCount > 0)
            {
                if (line.Contains("ARRAY"))
                {
                    attribute.Aggregation = IFCAggregation.ARRAY;
                }
                if (line.Contains("BAG"))
                {
                    attribute.Aggregation = IFCAggregation.BAG;
                }
                if (line.Contains("LIST"))
                {
                    attribute.Aggregation = IFCAggregation.LIST;
                }
                if (line.Contains("SET"))
                {
                    attribute.Aggregation = IFCAggregation.SET;
                }
            }
        }
        public override List<string> GetCSharpTexts()
        {
            List<string> texts = GetCSharpSummaryTexts();
            texts.Add(GetCSharpHeaderText());
                 
            texts.Add("\t{");
            var parents = ParentClasses;

            // variables
            foreach (var attribute in ParameterClassAttributes)
            {
                if (parents.FirstOrDefault(p => p.AdditionalSelectAttibutes.FirstOrDefault(e => e.Name == attribute.Name) != null) == null)
                {
                    texts.AddRange(attribute.GetCSharpText());
                }
            }
            foreach (var attribute in DeriveClassAttributes)
            {
                texts.AddRange(attribute.GetCSharpText());
            }
            foreach (var attribute in AdditionalSelectAttibutes)
            {
                texts.AddRange(attribute.GetCSharpText());
            }
            foreach (var attribute in InverseClassAttributes)
            {
                texts.AddRange(attribute.GetCSharpText());
            }
            foreach (var attribute in WhereClassAttributes)
            {
                texts.AddRange(attribute.GetCSharpText());
            }

            // constructor with no parameters
            texts .Add("\t\tpublic " + Name + "() : base()" );
            texts.Add("\t\t{");
            texts.Add("\t\t}");

           
            // constructor with parameters
            var attributes = DirectAttributes;
            if(attributes.Count > 0)
            {
                string constructor = "\t\tpublic " + Name + "(";
                for (int i = 0; i < attributes.Count; i++)
                {
                    constructor += attributes[i].GetCSharpTypeText() + "? " + attributes[i].Name + (i < attributes.Count - 1 ? ", " : "");
                }
                constructor += ") : base (";
                attributes = ParentsDirectAttributes;
                for (int i = 0; i < attributes.Count; i++)
                {
                    constructor += attributes[i].Name + (i < attributes.Count - 1 ? ", " : "");
                }
                constructor += ")";
                texts.Add(constructor);
                texts.Add("\t\t{");
                foreach (var attribute in ParameterClassAttributes)
                {
                    texts.Add("\t\t\tthis." + attribute.Name + " = " + attribute.Name + ";");
                }
                texts.Add("\t\t}");
            }
            
            // get parameter function
            texts.Add("\t\tpublic override Dictionary<string, IFC_Attribute?> GetDirectAttributes()");
            texts.Add("\t\t{");
            texts.Add("\t\t\treturn new Dictionary<string, IFC_Attribute?>()");
            texts.Add("\t\t\t{");

            var directAttributes = DirectAttributes;
            for(int i = 0; i < directAttributes.Count; i++)
            {
                texts.Add("\t\t\t\t{\"" + directAttributes[i].Name + "\", " + directAttributes[i].Name + "}" + (i < directAttributes.Count - 1 ? "," : ""));
            }
            texts.Add("\t\t\t};");
            texts.Add("\t\t}");

            // get parameter function
            texts.Add("\t\tpublic override Dictionary<string, IFC_Attribute?> GetDerivedAttributes()");
            texts.Add("\t\t{");
            texts.Add("\t\t\treturn new Dictionary<string, IFC_Attribute?>()");
            texts.Add("\t\t\t{");
            var derivedAttributes = DerivedAttributes;
            for (int i = 0; i < derivedAttributes.Count; i++)
            {
                texts.Add("\t\t\t\t{\""+ derivedAttributes[i].Name + "\", " + derivedAttributes[i].Name + "}" + (i < derivedAttributes.Count - 1 ? "," : ""));
            }
            texts.Add("\t\t\t};");
            texts.Add("\t\t}");

            // get parameter function
            texts.Add("\t\tpublic override Dictionary<string, IFC_Attribute?> GetInverseAttributes()");
            texts.Add("\t\t{");
            texts.Add("\t\t\treturn new Dictionary<string, IFC_Attribute?>()");
            texts.Add("\t\t\t{");
            var inverseAttributes = InverseAttributes;
            for (int i = 0; i < inverseAttributes.Count; i++)
            {
                texts.Add("\t\t\t\t{\"" + inverseAttributes[i].Name + "\", " + inverseAttributes[i].Name + "}" + (i < inverseAttributes.Count - 1 ? "," : ""));
            }
            texts.Add("\t\t\t};");
            texts.Add("\t\t}");

            texts.Add("\t\tpublic override Dictionary<string, bool> GetWhereAttributes()");
            texts.Add("\t\t{");
            texts.Add("\t\t\treturn new Dictionary<string, bool>()");
            texts.Add("\t\t\t{");
            var whereAttributes = WhereAttributes;
            for (int i = 0; i < whereAttributes.Count; i++)
            {
                texts.Add("\t\t\t\t{\"" + whereAttributes[i].Name.Replace("WR_","") + "\", " + whereAttributes[i].Name + "}" + (i < whereAttributes.Count - 1 ? "," : ""));
            }
            texts.Add("\t\t\t};");
            texts.Add("\t\t}");

            var selectDatas = DataSet.SelectTypes.Where(e => e.VersionName == VersionName).ToList();
            var entityDatas = DataSet.Entities.Where(e => e.VersionName == VersionName).ToList();
            var basicDatas = DataSet.BasicTypes.Where(e => e.VersionName == VersionName).ToList();
            var basicListDatas = DataSet.BasicTypeLists.Where(e => e.VersionName == VersionName).ToList();
            var enumDatas = DataSet.EnumTypes.Where(e => e.VersionName == VersionName).ToList();



            texts.Add("\t\tpublic override void SetByAttributeTexts()");
            texts.Add("\t\t{");

            texts.Add("\t\t\tif(Model != null)");
            texts.Add("\t\t\t{");
            texts.Add("\t\t\t\tif(AttributeTexts.Count != " + directAttributes.Count + ")");
            texts.Add("\t\t\t\t{");
            texts.Add("\t\t\t\t\tModel.ImportErrorLogTexts.Add(\"ERROR (\" + IFC_ID + \") : Invalid number of attributes. '" + Name + "' requires " + directAttributes.Count + " attributes (Not \" + AttributeTexts.Count + \"). \");");
            texts.Add("\t\t\t\t\treturn;");
            texts.Add("\t\t\t\t}");
            for (int i = 0; i < directAttributes.Count; i++)
            {
                string attText = "AttributeTexts[" + i + "]";
                var attribute = directAttributes[i];

                texts.Add("\t\t\t\tif(" + attText + " == \"$\")");
                texts.Add("\t\t\t\t{");
                if (!attribute.IsOptional)
                {
                    texts.Add("\t\t\t\t\tModel.ImportWarningLogTexts.Add(\"WARNING (\" + IFC_ID + \") : '" + attribute.Name + "' is not optional in '" + Name + "'\");");
                }
                texts.Add("\t\t\t\t\t" + attribute.Name + " = null;");
                texts.Add("\t\t\t\t}");
                texts.Add("\t\t\t\telse");
                texts.Add("\t\t\t\t{");
                texts.Add("\t\t\t\t}");
                if (attribute.AttributeType == IFCAttributeType.SINGLE)
                {
                    if (selectDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null)
                    {

                    }
                    else if (entityDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null)
                    {

                    }
                    else if (basicDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null)
                    {

                    }
                    else if (basicListDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null)
                    {

                    }
                    else if (enumDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null)
                    {

                    }
                }
                else if (attribute.AttributeType == IFCAttributeType.LIST)
                {

                }
                else
                {

                }
            }
            texts.Add("\t\t\t}");
            texts.Add("\t\t}");

            // get ifcfulltext
            texts.Add("\t\tpublic override string GetIFCFullText()");
            texts.Add("\t\t{");
            texts.Add("\t\t\tstring text = IFC_ID + \"=\" + GetType().Name.ToUpper() + \"(\";");
            for(int i = 0; i < directAttributes.Count; i++)
            {
                string comma = i < (directAttributes.Count - 1) ? "," : "";
                var attribute = directAttributes[i];
                if (derivedAttributes.FirstOrDefault(e => e.Name == attribute.Name) != null)
                {
                    texts.Add("\t\t\ttext += \"*" + comma + "\";");
                }
                else
                {
                    texts.Add("\t\t\tif(" + attribute.Name + " != null)");
                    texts.Add("\t\t\t{");

                    if (comma.Length > 0)
                    {
                        if (selectDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null)
                        {
                            texts.Add("\t\t\t\ttext += " + attribute.Name + ".GetIFCText(true) + \"" + comma + "\";");
                        }
                        else
                        {
                            texts.Add("\t\t\t\ttext += " + attribute.Name + ".GetIFCText(false) + \"" + comma + "\";");
                        }
                    }
                    else
                    {
                        if (selectDatas.FirstOrDefault(e => e.Name == attribute.TypeName) != null)
                        {
                            texts.Add("\t\t\t\ttext += " + attribute.Name + ".GetIFCText(true);");
                        }
                        else
                        {
                            texts.Add("\t\t\t\ttext += " + attribute.Name + ".GetIFCText(false);");
                        }
                    }

                    texts.Add("\t\t\t}");
                    texts.Add("\t\t\telse");
                    texts.Add("\t\t\t{");
                    texts.Add("\t\t\t\ttext +=\"$" + comma + "\";");
                    texts.Add("\t\t\t}");
                }
            }

            texts.Add("\t\t\ttext += \");\";");
            texts.Add("\t\t\treturn text;");
            texts.Add("\t\t}");


            // Global
            foreach (var attribute in ParameterClassAttributes)
            {
                if (parents.FirstOrDefault(p => p.AdditionalSelectAttibutes.FirstOrDefault(e => e.Name == attribute.Name) != null) == null)
                {
                    texts.AddRange(attribute.GetCSharpGlobalText(DataSet));
                }
            }
            foreach (var attribute in DeriveClassAttributes)
            {
                texts.AddRange(attribute.GetCSharpGlobalText(DataSet));
            }
            foreach (var attribute in AdditionalSelectAttibutes)
            {
                texts.AddRange(attribute.GetCSharpGlobalText(DataSet));
            }
            foreach (var attribute in InverseClassAttributes)
            {
                texts.AddRange(attribute.GetCSharpGlobalText(DataSet));
            }

            texts.Add("\t}");

            return texts;
        }

        protected override string GetCSharpTypeText()
        {
            return IsAbstract ? "abstract class" : "class";
        }
        protected override string GetCSharpParentText()
        {
            if (ParentName.Length > 0)
            {
                return " : " + ParentName;
            }
            else
            {
                return " : " + VersionName.ToUpper() + "_Entity";
            }
        }
    }
}
