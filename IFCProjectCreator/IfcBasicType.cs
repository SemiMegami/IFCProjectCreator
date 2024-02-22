namespace IFCProjectCreator
{
    public class IFCBasicType : IFCClass
    {
    
        public IFCBasicType? ParentClass { get; set; }
        public List<IFCWhereAttribute> WhereAttributes { get; set; }
        public IFCBasicType(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            WhereAttributes = new List<IFCWhereAttribute>();
        }
        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_TYPE;");
            string[] words = header.Split(" ");
            foreach (string word in words)
            {
                foreach (var key in DataSet.CSharpBasicDataTypes.Keys)
                {
                    if(word.Contains(key))
                    {
                        ParentName = key;
                    }
                }
            }
            if(ParentName == "")
            {
                ParentName = words[words.Length - 1].Replace(";", "");
                if (ParentName.Contains("STRING"))
                {
                    ParentName = "STRING";
                }
            }
            ParentName = ParentName.Replace("Ifc", "IFC");
        }

        public override List<string> GetCSharpTexts()
        {
            string cSharpText = GetCSharpType();
            List<string> texts = GetCSharpSummaryTexts();
            texts.Add(GetCSharpHeaderText());

            // constructor
            texts.Add("\t{");
            texts.Add("\t\tpublic " + Name + "() : base () { }");
            texts.Add("\t\tpublic " + Name + "(" + cSharpText + " value) : base (value) { }");
            // implicit operator
            texts.AddRange(DataSet.GetImplicitText(Name, cSharpText));
            texts.Add("\t}");

            return texts;
        }

        /// <summary>
        /// Get C# type name
        /// </summary>
        /// <returns></returns>
        public virtual string GetCSharpType()
        {
            if (ParentClass == null)
            {
                return DataSet.CSharpBasicDataTypes[ParentName];
            }
            else
            {
                return ParentClass.GetCSharpType();
            }
        }

       
    }
}
