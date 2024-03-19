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
        public IFCDataSet? Dataset { get; set; }
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


                List<string> result = new List<string>()
                {
                    "\t\tpublic " + (isOverride? "override ": "virtual ") + GetCSharpTypeText() + "? " + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\t//MANUAL_GET_DERIVED : " + Entity.VersionName.ToUpper() + "." + Entity.Name.ToUpper() + "." + Name.ToUpper(),
                };
                //if(Dataset)

                if (!includeSet)
                {

                    return new List<string>
                    {
                        "\t\tpublic " + (isOverride? "override ": "virtual ") + GetCSharpTypeText() + "? " + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\t//MANUAL_GET_DERIVED : " + Entity.VersionName.ToUpper() + "." + Entity.Name.ToUpper() + "." + Name.ToUpper(),
                        "",
                        "\t\t\t\treturn null;",
                        "",
                        "\t\t\t\t//END_MANUAL",
                        "\t\t\t}",
                        "\t\t}",
                    };
                }
                else
                {
                    return new List<string>
                    {
                        "\t\tpublic " + (isOverride? "override ": "virtual ") + GetCSharpTypeText() + "? " + Name,
                        "\t\t{",
                        "\t\t\tget",
                        "\t\t\t{",
                        "\t\t\t\t//MANUAL_GET_DERIVED : " + Entity.VersionName.ToUpper() + "." + Entity.Name.ToUpper() + "." + Name.ToUpper(),
                        "",
                        "\t\t\t\treturn null;",
                        "",
                        "\t\t\t\t//END_MANUAL",
                        "\t\t\t}",

                        "\t\t\tset",
                        "\t\t\t{",
                        "\t\t\t\t//MANUAL_SET_DERIVED : " + Entity.VersionName.ToUpper() + "." + Entity.Name.ToUpper() + "." + Name.ToUpper(),
                        "",
                        "",
                        "\t\t\t\t//END_MANUAL",
                        "\t\t\t}",

                        "\t\t}",
                    };
                }

            }
            else
            {
                return new List<string> {};
            }
            
        }
    }
}
