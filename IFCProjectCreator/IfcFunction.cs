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
            typeName = typeName.Replace("Ifc", "IFC");
            IFCAggregation aggregation = IFCAggregation.NONE;
            IFCListType listType = IFCListType.SINGLE;
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
                    listType = IFCListType.SINGLE;
                    break;
                case 1:
                    listType = IFCListType.LIST;
                    break;
                case 2:
                    listType = IFCListType.LISTLIST;
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
                    IFCAttribute input = new IFCParameterAttribute();
                    input.Name = names[i].Replace(" ", "");
                    input.TypeName = typeName;
                    input.ListType = listType;
                    input.Aggregation = aggregation;
                    Inputs.Add(input);
                }
            }
        }
        private void SetOutput(string outputText)
        {
            Output = new IFCParameterAttribute();
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
            Output.TypeName = Output.TypeName.Replace("Ifc", "IFC");
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
                    Output.ListType = IFCListType.SINGLE;
                    break;
                case 1:
                    Output.ListType = IFCListType.LIST;
                    break;
                case 2:
                    Output.ListType = IFCListType.LISTLIST;
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
            if (Output != null)
            {
                string outputType = Output.GetCSharpTypeText();
                bool isGeneric = false;
                if(outputType.Contains("GENERIC") || outputType.Contains("Item"))
                {
                    if(DataSet.GetItems(VersionName).FirstOrDefault(e=>e.Name == Output.TypeName) == null)
                    {
                        isGeneric = true;
                    }
                }
                if (isGeneric)
                {
                    outputType = outputType.Replace("GENERIC", "T").Replace("Item", "T");
                }

                bool canWrite = false;
                if(Output.ListType == IFCListType.LIST || Output.ListType == IFCListType.LISTLIST) 
                {
                    canWrite = true;
                }
                if (DataSet.CSharpBasicDataTypes.ContainsKey(outputType))
                {
                    canWrite = true;
                }
                if (DataSet.BasicTypes.FirstOrDefault(e=>e.VersionName == VersionName && e.Name == outputType) != null)
                {
                    canWrite = true;
                }
                if (DataSet.Entities.FirstOrDefault(e => e.VersionName == VersionName && e.Name == outputType && !e.IsAbstract) != null)
                {
                    canWrite = true;
                }

                string header = "\t\tprotected " + outputType + "? " + Name + (isGeneric? "<T>":"") +  "(";
                for (int i = 0; i < Inputs.Count; i++)
                {
                    string inputType = Inputs[i].GetCSharpTypeText();
                    if (isGeneric)
                    {
                        inputType = inputType.Replace("GENERIC", "T").Replace("Item", "T");
                    }
                    // fix error from express
                    if (inputType == "IFCSiUnitName")
                    {
                        inputType = "IFCSIUnitName";
                    }
                    header += inputType + " " + Inputs[i].Name;
                    if (i < Inputs.Count - 1)
                    {
                        header += ", ";
                    }
                }
                header += ")";
                if (isGeneric)
                {
                    header += " where T: IFC_Attribute";
                }
                List<string> texts = GetCSharpSummaryTexts();
                for(int i = 0; i < texts.Count; i++)
                {
                    texts[i] = "\t" + texts[i];
                }
                if (canWrite)
                {
                    texts.AddRange(new List<string>()
                    {
                        header,
                        "\t\t{",
                        "\t\t\t//MANUAL_FUNCTION : " + VersionName.ToUpper() + "." + Name.ToUpper(),
                        "",
                        "\t\t\t" + outputType + " result = new " + outputType + "();",
                        "\t\t\treturn result;",
                        "",
                        "\t\t\t//END_MANUAL",
                        "\t\t}"
                    });
                    return texts;
                }
                else
                {
                    texts.AddRange(new List<string>()
                    {
                        header,
                        "\t\t{",
                        "\t\t\t//MANUAL_FUNCTION : " + VersionName.ToUpper() + "." + Name.ToUpper(),
                        "",
                        outputType == "T"?"\t\t\treturn default(T);": "\t\t\treturn null;",
                        "",
                        "\t\t\t//END_MANUAL",
                        "\t\t}"
                    });
                    return texts;
                }
            }
            return new List<string>();
        }
    }
}
