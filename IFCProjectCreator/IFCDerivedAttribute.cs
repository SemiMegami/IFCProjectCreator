using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCDerivedAttribute : IFCAttribute
    {
        public string DeriveText { get; set; }
        public IFCEntity? Entity { get; set; }
        public bool includeSet { get; set; }

        public IFCDerivedAttribute() : base()
        {
            isReadOnly = true;
            DeriveText = "";
            includeSet = false;
        }

        public override List<string> GetCSharpText()
        {
            if (Entity != null)
            {

                var getValue = "//MANUAL_GET_DERIVED : " + Entity.VersionName.ToUpper() + "." + Entity.Name.ToUpper() + "." + Name.ToUpper();
                var setVelue = "//MANUAL_SET_DERIVED : " + Entity.VersionName.ToUpper() + "." + Entity.Name.ToUpper() + "." + Name.ToUpper();


                List<string> results = new List<string>()
                {
                    "\t\tpublic " + (isOverride? "override ": "virtual ") + GetCSharpTypeText() + "? " + Name,
                    "\t\t{",
                    "\t\t\tget",
                    "\t\t\t{",
                    "\t\t\t\t" + getValue,
                };
                if (Dataset != null && Dataset.ManualItems.TryGetValue(getValue, out List<string>? content))
                {
                    if(content != null)
                    {
                        foreach (var item in content)
                        {
                            results.Add(item);
                        }
                    }
                }
                else
                {
                    results.Add("");
                    results.Add("\t\t\t\treturn null;");
                    results.Add("");     
                }
                results.Add("\t\t\t\t//END_MANUAL");
                results.Add("\t\t\t}");


                if(includeSet)
                {
                    List<string> setResults = new List<string>()
                {
                    "\t\t\tset",
                    "\t\t\t{",
                    "\t\t\t\t" + setVelue,
                };
                    if (Dataset != null && Dataset.ManualItems.TryGetValue(setVelue, out List<string>? setContent))
                    {
                        if (setContent != null)
                        {
                            foreach (var item in setContent)
                            {
                                setResults.Add(item);
                            }
                        }
                    }
                    else
                    {
                        setResults.Add("");
                        setResults.Add("");
                    }
                    setResults.Add("\t\t\t\t//END_MANUAL");
                    setResults.Add("\t\t\t}");
                    results.AddRange(setResults);
                }

                results.Add("\t\t}");
                return results;
                //if (!includeSet)
                //{

                //    return new List<string>
                //    {
                //        "\t\tpublic " + (isOverride? "override ": "virtual ") + GetCSharpTypeText() + "? " + Name,
                //        "\t\t{",
                //        "\t\t\tget",
                //        "\t\t\t{",
                //        "\t\t\t\t//MANUAL_GET_DERIVED : " + Entity.VersionName.ToUpper() + "." + Entity.Name.ToUpper() + "." + Name.ToUpper(),
                //        "",
                //        "\t\t\t\treturn null;",
                //        "",
                //        "\t\t\t\t//END_MANUAL",
                //        "\t\t\t}",
                //        "\t\t}",
                //    };
                //}
                //else
                //{
                //    return new List<string>
                //    {
                //        "\t\tpublic " + (isOverride? "override ": "virtual ") + GetCSharpTypeText() + "? " + Name,
                //        "\t\t{",
                //        "\t\t\tget",
                //        "\t\t\t{",
                //        "\t\t\t\t//MANUAL_GET_DERIVED : " + Entity.VersionName.ToUpper() + "." + Entity.Name.ToUpper() + "." + Name.ToUpper(),
                //        "",
                //        "\t\t\t\treturn null;",
                //        "",
                //        "\t\t\t\t//END_MANUAL",
                //        "\t\t\t}",

                //        "\t\t\tset",
                //        "\t\t\t{",
                //        "\t\t\t\t//MANUAL_SET_DERIVED : " + Entity.VersionName.ToUpper() + "." + Entity.Name.ToUpper() + "." + Name.ToUpper(),
                //        "",
                //        "",
                //        "\t\t\t\t//END_MANUAL",
                //        "\t\t\t}",

                //        "\t\t}",
                //    };
                //}

            }
            else
            {
                return new List<string> {};
            }
            
        }
    }
}
