using System;
using IFC.IFC4;
using IFC;
using System.Numerics;
#pragma warning disable VSSpell001 // Spell Check
namespace TestIFCApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector3 v;

            new IFC_Test().TestLoad();

            //Console.WriteLine("Hello World!");

            //string IFCDir = "../../../../IFCSamples/";
            //IFC.IFC_Model model = new IFC_Model();
            //model.ImportIFC(IFCDir + "20160125WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Structural.ifc");
        }

        /// <summary>
        /// ddddddd
        /// </summary>
        void TestFunction()
        {

        }
    }
}