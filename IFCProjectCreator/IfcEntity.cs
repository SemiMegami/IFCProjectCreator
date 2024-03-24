using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            ClassType = IFCAttributeType.ENTITY;
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
            string listType = "";
            
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
                        listType = attType.Replace(" ", "");
                    }
                    
                }
          
                if (line.Contains(':'))
                {
                    if (listType == "")
                    {
                        IFCParameterAttribute IFCAttribute = new IFCParameterAttribute();
                        IFCAttribute.Dataset = DataSet;
                        IFCAttribute.IsOptional = line.Contains("OPTIONAL");
                        SetlistType(IFCAttribute, line, nW);
                        ParameterClassAttributes.Add(IFCAttribute);
                    }
                    else if (listType == "DERIVE")
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
                        IFCAttribute.Dataset = DataSet;
                        if (strings.Length > 1)
                        {
                            IFCAttribute.DeriveText = line.Split(" := ")[1];
                        }
                        else
                        {
                            IFCAttribute.DeriveText = reader.ReadLine()?? "";
                        }
                        SetlistType(IFCAttribute, line, splitIndex);
                        DeriveClassAttributes.Add(IFCAttribute);
                    }
                    else if (listType == "INVERSE")
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
                        IFCAttribute.Dataset = DataSet;
                        SetlistType(IFCAttribute, line, splitIndex);
                        IFCAttribute.RelatedAttributeName = words[nW - 1].Replace(";", "");
                        InverseClassAttributes.Add(IFCAttribute);
                    }
                    else if(listType == "WHERE")
                    {
                        IFCWhereAttribute IFCAttribute = new IFCWhereAttribute();
                        IFCAttribute.Dataset = DataSet;
                        IFCAttribute.Name = "WR_" + words[0].Replace(" ", "");
                        IFCAttribute.Entity = this;
                        WhereClassAttributes.Add(IFCAttribute);
                    }
                }
            }
        }


        private void SetlistType(IFCAttribute attribute, string line, int splitIndex)
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
                    attribute.ListType = IFCListType.SINGLE;
                    break;
                case 1:
                    attribute.ListType = IFCListType.LIST;
                    break;
                case 2:
                    attribute.ListType = IFCListType.LISTLIST;
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

            var selectDatas = DataSet.SelectTypes.Where(e => e.VersionName == VersionName).ToList();
            var entityDatas = DataSet.Entities.Where(e => e.VersionName == VersionName).ToList();
            var basicDatas = DataSet.BasicTypes.Where(e => e.VersionName == VersionName).ToList();
            var basicListDatas = DataSet.BasicTypeLists.Where(e => e.VersionName == VersionName).ToList();
            var enumDatas = DataSet.EnumTypes.Where(e => e.VersionName == VersionName).ToList();

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

            var attributes = DirectAttributes;
            var directAttributes = DirectAttributes;
            // constructor with no parameters
            texts .Add("\t\tpublic " + Name + "() : base()" );
            texts.Add("\t\t{");

            //foreach (var attribute in ParameterClassAttributes)
            //{
            //    if (!attribute.IsOptional)
            //    {
            //        if (attribute.ListType == IFCListType.SINGLE)
            //        {
            //            var selectItem = selectDatas.FirstOrDefault(e => e.Name == attribute.TypeName);
            //            if (selectItem != null)
            //            {
            //                var subclasses = selectItem.FinalSubclasses;
                           
            //                if (subclasses.Count > 0)
            //                {
            //                    texts.Add("\t\t\t" + attribute.Name + " = new " + subclasses[0].Name + "();");
            //                }
            //            }
            //            var absItem = entityDatas.FirstOrDefault(e => e.Name == attribute.TypeName && e.IsAbstract);
            //            if (absItem != null)
            //            {
            //                var subclasses = absItem.FinalSubclasses;
            //                if (subclasses.Count > 0)
            //                {
            //                    texts.Add("\t\t\t" + attribute.Name + " = new " + subclasses[0].Name + "();");
            //                }
            //            }
            //            if (selectItem == null && absItem == null)
            //            {
            //                texts.Add("\t\t\t" + attribute.Name + " = new " + attribute.TypeName + "();");
            //            }
            //        }
            //        else
            //        {
            //            texts.Add("\t\t\t" + attribute.Name + " = new " + attribute.GetCSharpTypeText() + "();");
            //        }
                    
            //    }
            //}


            texts.Add("\t\t}");

           
            // constructor with parameters
           
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
            texts.Add("\t\tpublic override Dictionary<string, IFC_BASE?> GetDirectAttributes()");
            texts.Add("\t\t{");
            texts.Add("\t\t\treturn new Dictionary<string, IFC_BASE?>()");
            texts.Add("\t\t\t{");

           
            for(int i = 0; i < directAttributes.Count; i++)
            {
                texts.Add("\t\t\t\t{\"" + directAttributes[i].Name + "\", " + directAttributes[i].Name + "}" + (i < directAttributes.Count - 1 ? "," : ""));
            }
            texts.Add("\t\t\t};");
            texts.Add("\t\t}");

            // get parameter function
            texts.Add("\t\tpublic override Dictionary<string, IFC_BASE?> GetDerivedAttributes()");
            texts.Add("\t\t{");
            texts.Add("\t\t\treturn new Dictionary<string, IFC_BASE?>()");
            texts.Add("\t\t\t{");
            var derivedAttributes = DerivedAttributes;
            for (int i = 0; i < derivedAttributes.Count; i++)
            {
                texts.Add("\t\t\t\t{\""+ derivedAttributes[i].Name + "\", " + derivedAttributes[i].Name + "}" + (i < derivedAttributes.Count - 1 ? "," : ""));
            }
            texts.Add("\t\t\t};");
            texts.Add("\t\t}");

            // get parameter function
            texts.Add("\t\tpublic override Dictionary<string, IFC_BASE?> GetInverseAttributes()");
            texts.Add("\t\t{");
            texts.Add("\t\t\treturn new Dictionary<string, IFC_BASE?>()");
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

  



            texts.Add("\t\tpublic override void SetByAttributeTexts()");
            texts.Add("\t\t{");

            texts.Add("\t\t\tif(Model != null)");
            texts.Add("\t\t\t{");
            texts.Add("\t\t\t\tif(AttributeTexts.Count != " + directAttributes.Count + ")");
            texts.Add("\t\t\t\t{");
            texts.Add("\t\t\t\t\tModel.Logs.Add(new IFC_LOG(IFC_LOGTYPE.ERROR, this, \"Invalid number of attributes. '" + Name + "' requires " + directAttributes.Count + " attributes (Not \" + AttributeTexts.Count + \").\"));");
            texts.Add("\t\t\t\t\treturn;");
            texts.Add("\t\t\t\t}");
            for (int i = 0; i < directAttributes.Count; i++)
            {

               

                string attText = "AttributeTexts[" + i + "]";
                var attribute = directAttributes[i];
                if (derivedAttributes.FirstOrDefault(e => e.Name == attribute.Name) != null)
                {
                    texts.Add("\t\t\t\t// SKIP : " + attText + " for " + attribute.Name + ".");
                    continue;
                }
                texts.Add("\t\t\t\tif(" + attText + " == \"$\")");
               
                if (!attribute.IsOptional)
                {
                    texts.Add("\t\t\t\t{");
                    texts.Add("\t\t\t\t\tModel.Logs.Add(new IFC_LOG(IFC_LOGTYPE.WARNING, this, \"'" + attribute.Name + "' is not optional in '" + Name + "'.\"));");
                }
                texts.Add("\t\t\t\t\t" + attribute.Name + " = null;");
                if (!attribute.IsOptional)
                {
                    texts.Add("\t\t\t\t}");
                }
                texts.Add("\t\t\t\telse");
                texts.Add("\t\t\t\t{");


                string basicType = "";
                var basic = DataSet.BasicTypes.FirstOrDefault(t => t.Name == attribute.TypeName && t.VersionName == VersionName);
                if (basic != null)
                {
                    basicType = basic.GetBasicType();
                }
                if (DataSet.CSharpBasicDataTypes.ContainsKey(attribute.TypeName))
                {
                    basicType = attribute.TypeName;
                }

                string attTypeName = attribute.TypeName;
                if (DataSet.CSharpBasicDataTypes.ContainsKey(attTypeName))
                {
                    attTypeName = "IFC_" + attTypeName;
                }

                if (attribute.ListType == IFCListType.SINGLE)
                {                
                    AddCsharpImportTextsForSingleValue(texts, attText, "\t\t\t\t\t", attribute.Name, attribute.Name, attribute.TypeName, attribute.ListType, attribute.AttributeType, basicType);
                }
                else if (attribute.ListType == IFCListType.LIST)
                {
                    var listName = attribute.GetListName();

                   

                    texts.Add("\t\t\t\t\t" + attribute.Name + " = new " + listName + "<" + attTypeName + ">();");
                    texts.Add("\t\t\t\t\tList<string>? attributeTexts = SplitList(" + attText + ");");
                    texts.Add("\t\t\t\t\tif(attributeTexts != null)");
                    texts.Add("\t\t\t\t\t{");
                    texts.Add("\t\t\t\t\t\tforeach (string attributeText in attributeTexts)");
                    texts.Add("\t\t\t\t\t\t{");
                    AddCsharpImportTextsForSingleValue(texts, "attributeText", "\t\t\t\t\t\t\t", attribute.Name, attribute.Name, attribute.TypeName, attribute.ListType, attribute.AttributeType, basicType);
                    texts.Add("\t\t\t\t\t\t}");
                    texts.Add("\t\t\t\t\t}");
                }
                else
                {
                    var listName = attribute.GetListName();
                    texts.Add("\t\t\t\t\t" + attribute.Name + " = new " + listName + "<" + listName + "<" + attTypeName + ">>();");
                    texts.Add("\t\t\t\t\tList<string>? attributeListTexts = SplitList(" + attText + ");");
                    texts.Add("\t\t\t\t\tif(attributeListTexts != null)");
                    texts.Add("\t\t\t\t\t{");
                    texts.Add("\t\t\t\t\t\tforeach (string attributeListText in attributeListTexts)");
                    texts.Add("\t\t\t\t\t\t{");
                    texts.Add("\t\t\t\t\t\t\tvar " + attribute.Name + "List = new " + listName + "<" + attTypeName + ">();");
                    texts.Add("\t\t\t\t\t\t\tList<string>? attributeTexts = SplitList(attributeListText);");
                    texts.Add("\t\t\t\t\t\t\tif(attributeTexts != null)");
                    texts.Add("\t\t\t\t\t\t\t{");
                    texts.Add("\t\t\t\t\t\t\t\tforeach (string attributeText in attributeTexts)");
                    texts.Add("\t\t\t\t\t\t\t\t{");
                    AddCsharpImportTextsForSingleValue(texts, "attributeText", "\t\t\t\t\t\t\t\t\t", attribute.Name, attribute.Name + "List", attribute.TypeName, IFCListType.LIST, attribute.AttributeType, basicType);
                    texts.Add("\t\t\t\t\t\t\t\t}");
                    texts.Add("\t\t\t\t\t\t\t}");
                    texts.Add("\t\t\t\t\t\t\t" + attribute.Name + ".Add(" + attribute.Name + "List);");
                    texts.Add("\t\t\t\t\t\t}");
                    texts.Add("\t\t\t\t\t}");
                }
                texts.Add("\t\t\t\t}");
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

        private void AddCsharpImportTextsForSingleValue(List<string> texts,string attText, string tap, string trueName, string name, string typeName, IFCListType listType, IFCAttributeType attributeType, string basicType, bool asInterface = false, bool suppressError = false)
        {
            var selectDatas = DataSet.SelectTypes.Where(e => e.VersionName == VersionName).ToList();
            var entityDatas = DataSet.Entities.Where(e => e.VersionName == VersionName).ToList();
            var basicDatas = DataSet.BasicTypes.Where(e => e.VersionName == VersionName).ToList();
            var basicListDatas = DataSet.BasicTypeLists.Where(e => e.VersionName == VersionName).ToList();
            var enumDatas = DataSet.EnumTypes.Where(e => e.VersionName == VersionName).ToList();
            string trimText = "";
            switch (attributeType)
            {
                case IFCAttributeType.ENTITY:
                    texts.Add(tap + "if(Model.Items.TryGetValue(" + attText + ",out IFC_I_ENTITY? value))");
                    texts.Add(tap + "{");
                    texts.Add(tap + "\tif(value is " + typeName + " item)");
                    switch (listType)
                    {
                        case IFCListType.SINGLE:
                            texts.Add(tap + "\t\t" + name + " = item;");
                            break;
                        case IFCListType.LIST:
                            texts.Add(tap + "\t\t" + name + ".Add(item);");
                            break;
                    }
                    texts.Add(tap + "\telse");
                    texts.Add(tap + "\t\tModel.Logs.Add(new IFC_LOG(IFC_LOGTYPE.ERROR, this, \"Cannot assign '\" + value.GetType().Name + \"' as '" + typeName + "' to '" + trueName + "'.\"));");
                    texts.Add(tap + "}");
                    if (!suppressError)
                    {
                        texts.Add(tap + "else");
                        texts.Add(tap + "\tModel.Logs.Add(new IFC_LOG(IFC_LOGTYPE.ERROR, this, \"'\" + " + attText + " + \"' not found.\"));");
                    }
                   
                    break;
                case IFCAttributeType.ENUM:

                    var enumItem = enumDatas.FirstOrDefault(e => e.Name == typeName && e.VersionName == VersionName);
                    texts.Add(tap + "switch (" + attText + ")");
                    texts.Add(tap + "{");
                    if (enumItem != null)
                    {
                        foreach (var v in enumItem.EnumValues)
                        {
                            if (v != null)
                            {
                                texts.Add(tap + "\tcase \"." + v + ".\" : " + name + " = " + attText + ".Replace(\".\",\"\"); break;");
                            }
                        }
                    }
                    texts.Add(tap + "\tdefault : Model.Logs.Add(new IFC_LOG(IFC_LOGTYPE.ERROR, this, \"Cannot assign '\" + " + attText + " + \"' as '" + typeName + "' to '" + trueName + "'.\")); break;");

                    texts.Add(tap + "}");

    
                    break;
                case IFCAttributeType.SELECT:

                    var selectItem = selectDatas.FirstOrDefault(e => e.Name == typeName && e.VersionName == VersionName);
                    if(selectItem != null)
                    {
                        var finalClassTypes = selectItem.GetAllIFCTypes();

                        if(finalClassTypes.IndexOf(IFCAttributeType.ENTITY) >= 0)
                        {
                            AddCsharpImportTextsForSingleValue(texts, attText, tap, trueName, name, typeName, listType, IFCAttributeType.ENTITY, basicType, true, finalClassTypes.Count > 1);
                        }

                        if(finalClassTypes.Where(e => e!= IFCAttributeType.ENTITY).Count() > 0)
                        {
                            string tap1 = tap;
                            if (finalClassTypes.IndexOf(IFCAttributeType.ENTITY) >= 0)
                            {
                                texts.Add(tap + "else");
                                texts.Add(tap + "{");
                                tap1 = tap1 + "\t";
                            }
                            texts.Add(tap1 + "string " + name + "Text = " + attText + ".Trim();");
                            texts.Add(tap1 + "int " + name + "NameLength = " + name + "Text.IndexOf('(');");
                            texts.Add(tap1 + "string " + name + "TypeName = " + name + "Text.Substring(0, " + name + "NameLength);");
                            texts.Add(tap1 + "string " + name + "Contain = " + name + "Text.Substring(" + name + "NameLength + 1, " + name +"Text.LastIndexOf(')') - 1 - " + name + "NameLength);");
                            texts.Add(tap1 + "switch (" + name + "TypeName)");
                            texts.Add(tap1 + "{");
                            foreach (var subClass in selectItem.AllNonAbstractSubclasses)
                            {
                                if (subClass.ClassType != IFCAttributeType.ENTITY && subClass.ClassType != IFCAttributeType.SELECT)
                                {
                                    string basicType1 = "";
                                    var basic = DataSet.BasicTypes.FirstOrDefault(t => t.Name == subClass.Name && t.VersionName == VersionName);
                                    if (basic != null)
                                    {
                                        basicType1 = basic.GetBasicType();
                                    }
                                    if (DataSet.CSharpBasicDataTypes.ContainsKey(subClass.Name))
                                    {
                                        basicType1 = subClass.Name;
                                    }
                                    texts.Add(tap1 + "\tcase \"" + subClass.Name.ToUpper() + "\":");
                                    texts.Add(tap1 + "\t\t" + subClass.Name + " " + subClass.Name.ToLower() + " = new " + subClass.Name + "();");
                                    AddCsharpImportTextsForSingleValue(texts, name + "Contain", tap1 + "\t\t", trueName, subClass.Name.ToLower(), subClass.Name, IFCListType.SINGLE, subClass.ClassType, basicType1, true);
                                    switch (listType)
                                    {
                                        case IFCListType.SINGLE:
                                            texts.Add(tap1 + "\t\t" + name + " = " + subClass.Name.ToLower() + ";");
                                            break;
                                        case IFCListType.LIST:
                                            texts.Add(tap1 + "\t\t" + name + ".Add(" + subClass.Name.ToLower() + ");");
                                            break;
                                    }

                                    texts.Add(tap1 + "\tbreak;");
                                } 
                            }
                            texts.Add(tap + "\tdefault : Model.Logs.Add(new IFC_LOG(IFC_LOGTYPE.ERROR, this, \"Cannot assign '\" + " + attText + " + \"' as '" + typeName + "' to '" + trueName + "'.\")); break; // Invalid Select");
                         

                            texts.Add(tap1 + "}");
                            if (finalClassTypes.IndexOf(IFCAttributeType.ENTITY) >= 0)
                            {
                                texts.Add(tap + "}");
                            }
                        }
                    }
                   
                    break;
                case IFCAttributeType.SIMPLE:
                    string dataType = "";
                    if (DataSet.CSharpBasicDataTypes.TryGetValue(basicType, out var value))
                    {
                        dataType = value;
                    }
                    if (dataType == "string")
                    {
                        trimText = "trim" + name;
                       
                        texts.Add(tap + "string "  + trimText + " = " + attText + ".Trim();");
                        texts.Add(tap + "if(" + trimText + ".Length > 1 && " + trimText + "[0] == '\\\'' && " + trimText + "[" + trimText + ".Count() - 1] == '\\'')");
                        texts.Add(tap + "{");
                        switch (listType)
                        {
                            case IFCListType.SINGLE:
                                texts.Add(tap + "\t" + name + " = " + trimText + ".Substring(1, " + trimText + ".Count() - 2);");
                                break;
                            case IFCListType.LIST:
                                texts.Add(tap + "\t" + name + ".Add(" + trimText + ".Substring(1, " + trimText + ".Count() - 2));");
                                break;
                        }
                        
                        texts.Add(tap + "}");
                        texts.Add(tap + "else Model.Logs.Add(new IFC_LOG(IFC_LOGTYPE.ERROR, this, \"Cannot assign '\" + " + attText + " + \"' as '" + typeName + "' to '" + trueName + "'.\"));");
                    }
                    else if (dataType == "int" || dataType == "double" || dataType == "float")
                    {
                        texts.Add(tap + "if(" + dataType + ".TryParse(" + attText + ",out " + dataType + " _" + name + "))");
                        switch (listType)
                        {
                            case IFCListType.SINGLE:
                                texts.Add(tap + "\t" + name + " = _" + name + ";");
                                break;
                            case IFCListType.LIST:
                                texts.Add(tap + name + ".Add(_" + name + ");");
                                break;
                        }
                        texts.Add(tap + "else Model.Logs.Add(new IFC_LOG(IFC_LOGTYPE.ERROR, this, \"Cannot assign '\" + " + attText + " + \"' as '" + typeName + "' to '" + trueName + "'.\"));");
                    }
                    else if (dataType == "bool")
                    {
                        switch (listType)
                        {
                            case IFCListType.SINGLE:
                                texts.Add(tap + "switch(" + attText + ")");
                                texts.Add(tap + "{");
                                texts.Add(tap + "\tcase  \".T.\": " + name + " = true; break;");
                                texts.Add(tap + "\tcase  \".F.\": " + name + " = false; break;");
                                if (basicType.Contains("LOGICAL"))
                                {
                                    texts.Add(tap + "\tcase  \".U.\": " + name + " = false; " + name + ".Unknown = true; break;");
                                }
                                texts.Add(tap + "\tdefault : Model.Logs.Add(new IFC_LOG(IFC_LOGTYPE.ERROR, this, \"Cannot assign '\" + " + attText + " + \"' as '" + typeName + "' to '" + trueName + "'.\")); break;");
                                texts.Add(tap + "}");
                                break;
                            case IFCListType.LIST:
                                texts.Add(tap + typeName + "value = null;");
                                texts.Add(tap + "switch(" + attText + ")");
                                texts.Add(tap + "{");
                                texts.Add(tap + "\tcase  \".T.\": value = true; break;");
                                texts.Add(tap + "\tcase  \".F.\": value = false; break;");
                                if (basicType.Contains("LOGICAL"))
                                {
                                    texts.Add(tap + "\tcase  \".U.\": value = false; value.Unknown = true; break;");
                                }
                                texts.Add(tap + "\tdefault : Model.Logs.Add(new IFC_LOG(IFC_LOGTYPE.ERROR, this, \"Cannot assign '\" + " + attText + " + \"' as '" + typeName + "' to '" + trueName + "'.\")); break;");

                                texts.Add(tap + "\t" + name + ".Add(value);");
                                texts.Add(tap + "}");
                                break;
                        }
                    }
                    break;
                case IFCAttributeType.SIMPLELIST:
                    texts.Add(tap + name + " = new " + typeName + "();");
                    texts.Add(tap + "List<string>? " + typeName + " = SplitList(" + attText + ");");
                    texts.Add(tap + "if(" + typeName + " != null)");
                    texts.Add(tap + "{");
                    texts.Add(tap + "\tforeach(string " + typeName + "Item in " + typeName + ")");
                    texts.Add(tap + "\t{");
                    var listItem = basicListDatas.FirstOrDefault(x => x.Name == typeName);
                    if(listItem != null)
                    {
                        var listBase = listItem.ParentName; 
                        AddCsharpImportTextsForSingleValue(texts, typeName + "Item", tap + "\t\t", trueName, name, typeName, IFCListType.LIST, IFCAttributeType.SIMPLE, listBase, true);
                    }
                    texts.Add(tap + "\t}");
                    texts.Add(tap + "}");
                    break;
            }
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
