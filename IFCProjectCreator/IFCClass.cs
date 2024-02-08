using Microsoft.SqlServer.Management.XEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace IFCProjectCreator
{
    public abstract class IFCClass
    {
        protected IFCDataSet DataSet;
        public string VersionName;
        public string Name;
        public string ParentName;
        public List<string> SubClassesNames;
        public List<string> InterfaceNames;
        public List<string> EXPLines;
        public List<IFCSelectType> ParentInterfaces;
        public List<IFCClass> SubClasses;
        
        /// <summary>
        /// Constructor of the IFC Class 
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="version"></param>
        public IFCClass(IFCDataSet dataSet, string version) {
            DataSet = dataSet;
            Name = "";
            ParentName = "";
            VersionName = version;
            SubClassesNames = new List<string>();
            InterfaceNames = new List<string>();
            EXPLines = new List<string>();
            ParentInterfaces = new List<IFCSelectType>();
            SubClasses = new List<IFCClass>();
        }
        /// <summary>
        /// Read EXP file and update class Data
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="header"></param>
        public abstract void ReadEXP(StreamReader reader, string header);



        /// <summary>
        /// Update class name and EXPTexts
        /// </summary>
        /// <param name="reader">IFC reader</param>
        /// <param name="header">First text</param>
        /// <param name="endText">Text which indicate that it is the end of the class</param>
        protected void GetNameAndEXPText(StreamReader reader, string header, string endText)
        {
            string[] headers = header.Split(' ');
            if(headers.Length > 1)
            {
                Name = header.Split(' ')[1].Replace(";", "");
            }
            EXPLines.Clear();
            EXPLines.Add(header);
            string? line = "";
            while (line != null && !line.Contains(endText))
            {
                if (reader != null)
                {
                    line = reader != null ? reader.ReadLine() : "";
                    if (line != null)
                    {
                        line = line.Trim();
                        EXPLines.Add(line);
                    }
                }
            }
        }

        #region ---- CSharp ----
    
        /// <summary>
        /// Return C# texts
        /// </summary>
        /// <returns></returns>
        public abstract List<string> GetCSharpTexts();

        /// <summary>
        /// Get Summary texts for class description
        /// </summary>
        /// <returns></returns>
        protected List<string> GetCSharpSummaryTexts()
        {
            List<string> summary = new List<string>();
            string s = "\t/// ";
            summary.Add(s + "<summary>");
            if(EXPLines.Count > 0)
            {
                summary.Add(s + EXPLines[0]);
            }
            int n = EXPLines.Count;
            for (int i = 0; i < n; i++)
            {
                summary.Add(s + "<para>" + EXPLines[i] + "</para>");
            }
            summary.Add(s + "<summary>");
            return summary;
        }

        /// <summary>
        /// Get class name text, parent class name, and interface name
        /// </summary>
        /// <returns></returns>
        protected virtual string GetCSharpHeaderText()
        {
            string parentText = GetCSharpParentText();
            string text = "\tpublic " + GetCSharpTypeText() + " " + Name + parentText;

            for(int i = 0; i < InterfaceNames.Count; i++)
            {
                if(i== 0 && parentText.Length == 0)
                {
                    text += ": " + InterfaceNames[i];
                }
                else
                {
                    text += ", " + InterfaceNames[i];
                }
            }
            return text;
        }

        /// <summary>
        /// Get text as class or interface
        /// </summary>
        /// <returns></returns>
        protected virtual string GetCSharpTypeText()
        {
            return "class";
        }

        /// <summary>
        /// Get Parent text
        /// </summary>
        /// <returns></returns>
        protected virtual string GetCSharpParentText()
        {
            if (ParentName.Length > 0)
            {
                return " : " + ParentName;
            }
            else
            {
                return "";
            }
        }

        #endregion

        public override string ToString()
        {
            return VersionName + ":" + Name;
        }

    }
}
