namespace IFCProjectCreator
{
    public class IFCEnumType : IFCClass
    {
        public List<string> EnumValues { get; set; }
        public IFCEnumType(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            EnumValues = new List<string>();
        }
        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_TYPE;");
            for (int i = 1; i < EXPLines.Count - 1; i++)
            {
                EnumValues.Add(EXPLines[i].Replace("(", "").Replace(")", "").Replace("\t", "").Replace(",", "").Replace(";", ""));
            }
        }

        public override List<string> GetCSharpTexts()
        {
            List<string> texts = GetCSharpSummaryTexts();
            texts.Add(GetCSharpHeaderText());
            texts.Add("\t{");
            foreach (string enumValue in EnumValues)
            {
                texts.Add("\t\tpublic static string " + enumValue + " { get {return \"." + enumValue +".\";} }"  );
            }

            foreach (var attribute in AdditionalSelectAttibutes)
            {
                texts.AddRange(attribute.GetCSharpText());
            }
            texts.Add("\t\tpublic string Value;");
            if(EnumValues.Count > 0)
            {
                texts.Add("\t\tpublic " + Name + "() { Value = \"." + EnumValues[0] + ".\";}");
            }
            else
            {
                texts.Add("\t\tpublic " + Name + "() { Value = \"\";}");
            }
            
            texts.Add("\t\tpublic " + Name + "(" + "string" + " value) { Value = value; }");

            // implicit operator
            texts.AddRange(DataSet.GetImplicitText(Name, "string"));

            texts.Add("\t}");
            return texts;
        }
    }
}
