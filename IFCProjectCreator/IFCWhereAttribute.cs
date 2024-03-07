﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public class IFCWhereAttribute : IFCAttribute
    {
        public string WhereText { get; set; }
        public IFCEntity? Entity { get; set; }
        public IFCWhereAttribute() : base() 
        {
            WhereText = "";
        }

        public override List<string> GetCSharpText()
        {
            if (Entity != null)
            {
                return new List<string>()
                {
                  "\t\tpublic " + (isOverride?"override":"virtual") +  " bool " + Name,
                  "\t\t{",
                  "\t\t\tget",
                  "\t\t\t{",
                  "\t\t\t\t//MANUAL_WHERE : " + Entity.VersionName.ToUpper() + "." + Entity.Name.ToUpper() + "." + Name.ToUpper(),
                  "",
                  "\t\t\t\treturn true;",
                  "",
                  "\t\t\t\t//END_MANUAL",
                  "\t\t\t}",
                  "\t\t}"
                };
            }
            return new List<string>();  
              
        }
    }
}
