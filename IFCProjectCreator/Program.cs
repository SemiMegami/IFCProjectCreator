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
            string resourceDir = "D:\\Program_Projects\\IFCProjectCreator\\Resources\\";

     
     
            IfcDataSet dataSet = new IfcDataSet();
            dataSet.ReadExp(resourceDir + "IFC2X3_TC1.exp", "Ifc2x3");
            dataSet.ReadExp(resourceDir + "IFC4.exp", "Ifc4");
            dataSet.ReadExp(resourceDir + "IFC4x1.exp", "Ifc4x1");
            dataSet.ReadExp(resourceDir + "IFC4x2.exp", "Ifc4x2");
            dataSet.ReadExp(resourceDir + "IFC4X3_ADD2.exp", "Ifc4x3");
            var SpecialEnums = dataSet.EnumTypes.Where(e => e.ParentInterfaces.Count() > 0).ToList();
        }


    }
}