using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
namespace IFCProjectCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resourceDir = "../../../../Resources/";
            string resultDir = "../../../../GeneratedIFCLibrary/";
            string manualDir = "../../../../IFC/";
            IFCDataSet dataSet = new IFCDataSet();
            dataSet.ReadData(resourceDir + "IFC2X3_TC1.exp", "IFC2x3");
            dataSet.ReadData(resourceDir + "IFC4.exp", "IFC4");
            dataSet.ReadData(resourceDir + "IFC4x1.exp", "IFC4x1");
            dataSet.ReadData(resourceDir + "IFC4x2.exp", "IFC4x2");
            dataSet.ReadData(resourceDir + "IFC4X3_ADD2.exp", "IFC4x3");
            dataSet.ReadManualItem(manualDir + "IFC2x3.cs");
            dataSet.ReadManualItem(manualDir + "IFC4.cs");
            dataSet.ReadManualItem(manualDir + "IFC4x1.cs");
            dataSet.ReadManualItem(manualDir + "IFC4x2.cs");
            dataSet.ReadManualItem(manualDir + "IFC4x3.cs");
            dataSet.SetGlobal();
            dataSet.WriteCSharp(resultDir, "IFC");
         

        }
    }
}