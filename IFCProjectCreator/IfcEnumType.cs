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
                texts.Add("\t\tpublic static string " + enumValue + " { get {return \"" + enumValue +"\";} }"  );
            }
            // implicit operator
            string cSharpText = "string";
            texts.Add("\t\tpublic static implicit operator " + Name + "(" + cSharpText + " value) { return new " + Name + "(" + cSharpText + ");}");
            texts.Add("\t\tpublic static implicit operator " + cSharpText + "(" + Name + " value) { return value.Value;}");


            texts.Add("\t}");
            return texts;
        }
    }
}
