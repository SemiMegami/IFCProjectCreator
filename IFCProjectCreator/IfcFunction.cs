using System.Data;
using System.Runtime.InteropServices;

namespace IFCProjectCreator
{
    public class IFCFunction : IFCClass
    {


        public List<IFCParameterAttribute> Inputs { get; set; }
        public IFCParameterAttribute? Output { get; set; }

        public bool IsNullAble { get; set; }
        public IFCFunction(IFCDataSet dataSet, string version) : base(dataSet, version)
        {
            Inputs = new List<IFCParameterAttribute>();
            IsNullAble = false;
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

            foreach(var line in EXPLines)
            {
                if (line.Contains("RETURN(?)") || line.Contains("RETURN (?)") || line.Contains(":= ?;"))
                {
                    IsNullAble = true;
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
                    IFCParameterAttribute input = new IFCParameterAttribute();
                    input.Name = names[i].Replace(" ", "");
                    input.Dataset = DataSet;
                    input.TypeName = typeName;
                    input.ListType = listType;
                    input.Aggregation = aggregation;
                    input.IsOptional = false;
                    foreach (var line in EXPLines)
                    {
                        if (line.Contains("EXISTS(" + names[i].Trim() + ")") || line.Contains("EXISTS (" + names[i].Trim() + ")") || line.Contains("NVL(IfcNormalise(" + names[i].Trim() + ")"))
                        {
                          
                            input.IsOptional = true;
                        }
                    }

                    Inputs.Add(input);
                }


            }
        }
        private void SetOutput(string outputText)
        {
            Output = new IFCParameterAttribute();
            Output.Dataset = DataSet;
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
              
                if (outputType.Contains("GENERIC") || outputType.Contains("Item"))
                {
                    if (DataSet.GetItems(VersionName).FirstOrDefault(e => e.Name == Output.TypeName) == null)
                    {
                        isGeneric = true;
                    }
                }
                if (isGeneric)
                {
                    outputType = outputType.Replace("GENERIC", "T").Replace("Item", "T");
                }
                string returnOutput = outputType;
                bool canWrite = false;
                if (Output.ListType == IFCListType.LIST || Output.ListType == IFCListType.LISTLIST)
                {
                    canWrite = true;
                }
                if (DataSet.CSharpBasicDataTypes.ContainsKey(outputType))
                {
                    canWrite = true;
                }
                if (DataSet.BasicTypes.FirstOrDefault(e => e.VersionName == VersionName && e.Name == outputType) != null)
                {
                    canWrite = true;
                }
                if (DataSet.Entities.FirstOrDefault(e => e.VersionName == VersionName && e.Name == outputType && !e.IsAbstract) != null)
                {
                    canWrite = true;
                }
                if (DataSet.Entities.FirstOrDefault(e => e.VersionName == VersionName && e.Name == outputType && e.IsAbstract) != null)
                {
                    var item = DataSet.Entities.FirstOrDefault(e => e.VersionName == VersionName && e.Name == outputType && e.IsAbstract);
                    if (item != null)
                    {
                        var subclass = item.FinalSubclasses;
                        if (subclass.Count > 0)
                        {
                            returnOutput = subclass[0].Name;
                            canWrite = true;
                        }
                    }
                }
                if (DataSet.SelectTypes.FirstOrDefault(e => e.VersionName == VersionName && e.Name == outputType) != null)
                {
                    var item = DataSet.SelectTypes.FirstOrDefault(e => e.VersionName == VersionName && e.Name == outputType);
                    if(item != null)
                    {
                        var subclass = item.FinalSubclasses;
                        if(subclass.Count > 0)
                        {
                            returnOutput = subclass[0].Name;
                            canWrite = true;
                        }
                    }
                }
                string header = "\t\tprotected " + outputType + ((IsNullAble || isGeneric)? "? " : " ") + Name + (isGeneric ? "<T>" : "") + "(";
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
                    if (Inputs[i].IsOptional)
                    {
                        header += inputType + "? " + Inputs[i].Name;
                    }
                    else
                    {
                        header += inputType + " " + Inputs[i].Name;
                    }
                    if (i < Inputs.Count - 1)
                    {
                        header += ", ";
                    }
                }
                header += ")";
                if (isGeneric)
                {
                    header += " where T: IFC_BASE";
                }
                List<string> texts = GetCSharpSummaryTexts();
                for (int i = 0; i < texts.Count; i++)
                {
                    texts[i] = "\t" + texts[i];
                }

                string functionKey = "//MANUAL_FUNCTION : " + VersionName.ToUpper() + "." + Name.ToUpper();
                if (DataSet != null && DataSet.ManualItems.TryGetValue(functionKey, out List<string>? content))
                {
                    texts.AddRange(new List<string>()
                    {
                        header,
                        "\t\t{",
                        "\t\t\t" + functionKey,
                    });
                    if(content != null)
                    {
                        foreach (var c in content)
                        {
                            texts.Add(c.Replace("IFC_BASES","IFC_" + Output.Aggregation.ToString()));
                        }
                    }
                    texts.AddRange(new List<string>()
                    {
                        "\t\t\t//END_MANUAL",
                        "\t\t}"
                    });
                    
                    return texts;
                }
                else
                {
                    if (canWrite)
                    {
                        texts.AddRange(new List<string>()
                        {
                            header,
                            "\t\t{",
                            "\t\t\t" + functionKey,
                            "",
                            "\t\t\t" + outputType + " result = new " + returnOutput + "();",
                            "\t\t\treturn result;",
                            "",
                            "\t\t\t//END_MANUAL",
                            "\t\t}"
                        });
                        return texts;
                    }
                    else if (outputType == "T")
                    {
                        texts.AddRange(new List<string>()
                        {
                            header,
                            "\t\t{",
                            "\t\t\t" + functionKey,
                            "",
                            outputType == "T"?"\t\t\treturn default(T);": "\t\t\treturn null;",
                            "",
                            "\t\t\t//END_MANUAL",
                            "\t\t}"
                        });
                        return texts;
                    }
                }
            }
            return new List<string>();
        }
    }
}
