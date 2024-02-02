namespace IFCProjectCreator
{
    public class IFCFunction : IFCClass
    {


        public List<IFCAttribute> Inputs { get; set; }
        public IFCAttribute? Output { get; set; }
        public IFCFunction(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            Inputs = new List<IFCAttribute>();
        }
        public override void ReadEXP(StreamReader reader, string header)
        {
            GetNameAndEXPText(reader, header, "END_FUNCTION;");

            // find header
            int startBracketIndex = -1;

            int returnIndex = -1;

            // find header dataline
            for (int i = 1; i < EXPLines.Count; i++)
            {
                if (EXPLines[i].Contains("("))
                {
                    startBracketIndex = i;
                }
                if (EXPLines[i].Contains(")"))
                {
                    string noSpace = EXPLines[i].Replace(" ", "");
                    returnIndex = noSpace.ElementAt(noSpace.Length - 1) == ';' ? i : (i + 1);
                    break;
                }
            }
            string headerLine = "";

            for (int i = startBracketIndex; i <= returnIndex; i++)
            {
                headerLine += EXPLines[i].ToString().Replace("\t", "");
            }
            string inputText = headerLine.Split(")")[0].Replace("(", "");
            string outputText = headerLine.Split(")")[1].Replace("(", "").Replace(";", "").Replace(":", "");
            SetInputs(inputText);
            SetOutput(outputText);

            Console.WriteLine(Name);
    

            Console.WriteLine("intput : ");
            foreach ( var input in Inputs )
            {
                Console.WriteLine("    " + input);
            }
            Console.WriteLine("output : ");
            Console.WriteLine("    " + Output);
            Console.WriteLine("");

        }

        private void SetInputs(string inputText)
        {
            string[] inputTexts= inputText.Split(";");
            for(int i = 0; i < inputTexts.Length; i++)
            {
                SetInput(inputTexts[i]);
            }
        }
        private void SetInput(string inputText)
        {
            string[] words = inputText.Split(":");
            string[] names = words[0].Split(",");

            string typeText = inputText.Substring(inputText.IndexOf(":") + 1);
            string[] wordArr = typeText.Split(" ");
            List<string> typeWords = new List<string>();
            for(int i = 0;i < wordArr.Length;i++)
            {
                if (wordArr[i].Length > 0)
                {
                    typeWords.Add(wordArr[i]);
                }
            }

            string typeName = typeText.Contains("GENERIC") ? "GENERIC" : typeWords[typeWords.Count - 1];

            IFCAggregation aggregation = IFCAggregation.NONE;
            IFCAttributeType attributeType = IFCAttributeType.SINGLE;
            int ofCount = 0;
            for (int i = 0; i < typeWords.Count; i++)
            {
                if (typeWords[i] == "OF")
                {
                    ofCount++;
                }
            }
            switch (ofCount)
            {
                case 0:
                    attributeType = IFCAttributeType.SINGLE;
                    break;
                case 1:
                    attributeType = IFCAttributeType.LIST;
                    break;
                case 2:
                    attributeType = IFCAttributeType.LISTLIST;
                    break;
            }
            if (ofCount > 0)
            {
                if (inputText.Contains("ARRAY"))
                {
                    aggregation = IFCAggregation.ARRAY;
                }
                if (inputText.Contains("BAG"))
                {
                    aggregation = IFCAggregation.BAG;
                }
                if (inputText.Contains("LIST"))
                {
                    aggregation = IFCAggregation.LIST;
                }
                if (inputText.Contains("SET"))
                {
                    aggregation = IFCAggregation.SET;
                }
            }

            for(int i = 0; i < names.Length;i++)
            {
                if (names[i].Length > 0)
                {
                    IFCAttribute input = new IFCAttribute();
                    input.Name = names[i].Replace(" ", "");
                    input.TypeName = typeName;
                    input.AttributeType = attributeType;
                    input.Aggregation = aggregation;
                    Inputs.Add(input);
                }
            }
        }
        private void SetOutput(string outputText)
        {
            Output = new IFCAttribute();
            Output.Name = "Output";
            string[] outputWordArrs = outputText.Split(" ");
            List<string> outputWords = new List<string>();
            for (int i = 0; i < outputWordArrs.Length; i++)
            {
                if (outputWordArrs[i].Length > 0)
                {
                    outputWords.Add(outputWordArrs[i]);
                }
            }

            Output.TypeName = outputText.Contains("GENERIC") ? "GENERIC" : outputWords[outputWords.Count - 1];
            int ofCount = 0;
            for (int i = 0; i < outputWords.Count; i++)
            {
                if (outputWords[i] == "OF")
                {
                    ofCount++;
                }
            }
            switch (ofCount)
            {
                case 0:
                    Output.AttributeType = IFCAttributeType.SINGLE;
                    break;
                case 1:
                    Output.AttributeType = IFCAttributeType.LIST;
                    break;
                case 2:
                    Output.AttributeType = IFCAttributeType.LISTLIST;
                    break;
            }
            if (ofCount > 0)
            {
                if (outputText.Contains("ARRAY"))
                {
                    Output.Aggregation = IFCAggregation.ARRAY;
                }
                if (outputText.Contains("BAG"))
                {
                    Output.Aggregation = IFCAggregation.BAG;
                }
                if (outputText.Contains("LIST"))
                {
                    Output.Aggregation = IFCAggregation.LIST;
                }
                if (outputText.Contains("SET"))
                {
                    Output.Aggregation = IFCAggregation.SET;
                }
            }
        }

        public override List<string> GetCSharpTexts()
        {
            List<string> texts = new List<string>();
            return texts;
        }
    }
}
