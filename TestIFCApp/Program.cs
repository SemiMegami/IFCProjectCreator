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

            IFCElectricCapacitanceMeasure testBasic = 5;
            double sss = testBasic;
            IFC.IFC_Model model = new IFC_Model("2x3");
            Console.WriteLine(sss);
            // var beams = model.GetItems<IFCBeam>();


            IFCActuatorTypeEnum testEnum = IFCActuatorTypeEnum.THERMOSTATICACTUATOR;
            Console.WriteLine(testEnum);

            IFCSIUnit siUnit = new IFCSIUnit();
            siUnit.Name = "METRE";
        }
    }

    public enum Days
    {
        Sunday,
        Monday
    }
}