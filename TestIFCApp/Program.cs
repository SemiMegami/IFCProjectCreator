using System;
using IFC.IFC4;
namespace TestIFCApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IfcPositiveInteger a = 5;

            int b = a;

            IfcArcIndex arc = new IfcArcIndex();
            arc.Add(b);
            List<int> d = arc;
            IfcArcIndex arc2 = d;
        }
    }
}