﻿using System;
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
            string resultDir = "../../../../Results/";

            IFCDataSet dataSet = new IFCDataSet();
            dataSet.ReadExp(resourceDir + "IFC2X3_TC1.exp", "IFC2x3");
            dataSet.ReadExp(resourceDir + "IFC4.exp", "IFC4");
            dataSet.ReadExp(resourceDir + "IFC4x1.exp", "IFC4x1");
            dataSet.ReadExp(resourceDir + "IFC4x2.exp", "IFC4x2");
            dataSet.ReadExp(resourceDir + "IFC4X3_ADD2.exp", "IFC4x3");

            var items = dataSet.GetItems("IFC4");

            using (StreamWriter writer = new StreamWriter(resultDir + "test.txt"))
            {
                foreach (var item in items)
                {
                    var texts = item.GetCSharpTexts();
                    foreach (var text in texts)
                    {
                        writer.WriteLine(text);
                    }
                    if (texts.Count > 0)
                    {
                        writer.WriteLine("--------------------------------");
                    }
                }
            }

        }
    }
}