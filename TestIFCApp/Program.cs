using System;
using IFC.IFC4;
using IFC;
#pragma warning disable VSSpell001 // Spell Check
namespace TestIFCApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string IFCDir = "../../../../IFCSamples/";
            IFC.IFC_Model model = new IFC_Model();
            model.ImportIFC(IFCDir + "20160125WestRiverSide Hospital - IFC4-Autodesk_Hospital_Metric_Structural.ifc");
        }
    }
}