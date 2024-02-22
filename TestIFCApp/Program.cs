using System;
using IFC.Global;
using IFC;
namespace TestIFCApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            IFC.IFC_Model model = new IFC_Model("2x3");
           // var beams = model.GetItems<IFCBeam>();
        }
    }
}