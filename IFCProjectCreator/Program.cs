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
            dataSet.ReadData(resourceDir + "IFC2X3_TC1.exp", "IFC2X3");
            dataSet.ReadData(resourceDir + "IFC4.exp", "IFC4");
            dataSet.ReadData(resourceDir + "IFC4x1.exp", "IFC4X1");
            dataSet.ReadData(resourceDir + "IFC4x2.exp", "IFC4X2");
            dataSet.ReadData(resourceDir + "IFC4X3_ADD2.exp", "IFC4X3");
            dataSet.ReadManualItem(manualDir + "IFC2X3.cs");
            dataSet.ReadManualItem(manualDir + "IFC4.cs");
            dataSet.ReadManualItem(manualDir + "IFC4X1.cs");
            dataSet.ReadManualItem(manualDir + "IFC4X2.cs");
            dataSet.ReadManualItem(manualDir + "IFC4X3.cs");
            dataSet.SetGLOBAL();
            dataSet.WriteCSharp(resultDir, "IFC");
         

        }
    }
}