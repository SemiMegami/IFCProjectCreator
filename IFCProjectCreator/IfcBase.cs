using Microsoft.SqlServer.Management.XEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace IFCProjectCreator
{
    public abstract class IfcBase
    {
        protected IfcDataSet DataSet;
        public string VersionName;
        public string Name;
        public string ParentName;
        public List<string> SubClassesNames;
        public List<string> InterfaceNames;
        public List<string> EXPLines;
        public List<IfcSelectType> ParentInterfaces;
        public List<IfcBase> SubClasses;

        public IfcBase(IfcDataSet dataSet, string version) {
            DataSet = dataSet;
            Name = "";
            ParentName = "";
            VersionName = version;
            SubClassesNames = new List<string>();
            InterfaceNames = new List<string>();
            EXPLines = new List<string>();
            ParentInterfaces = new List<IfcSelectType>();
            SubClasses = new List<IfcBase>();
        }
        public abstract void ReadEXP(StreamReader reader, string header);
        public abstract List<string> ToCShapText();

        protected void GetNameAndEXPText(StreamReader reader, string header, string endText)
        {
            Name = header.Split(' ')[1].Replace(";","");
            EXPLines.Clear();
            EXPLines.Add(header);
            string line = "";
            while (!line.Contains(endText))
            {
                line = reader.ReadLine();
                EXPLines.Add(line);
            }
        }
       
       
        public override string ToString()
        {
            return VersionName + ":" + Name;
        }
    }
}
