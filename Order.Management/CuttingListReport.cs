using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class CuttingListReport : Order
    {
        public int tableWidth = 20;
        public CuttingListReport(string customerName, string customerAddress, string dueDate, Dictionary<string, Dictionary<String, Toy>> OrderedRecords)
        {
            base.CustomerName = customerName;
            base.Address = customerAddress;
            base.DueDate = dueDate;
            base.OrderedRecords = OrderedRecords;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour cutting list has been generated: ");
            Console.WriteLine(base.ToString());
            generateTable();
        }
        public void generateTable()
        {
            PrintLine();
            PrintRow("        ", "   Qty   ");
            PrintLine();

            foreach (string shape in OrderedRecords.Keys)
            {
                int QuantitiyOfShape = 0;
                foreach (string color in OrderedRecords[shape].Keys)
                {
                    QuantitiyOfShape += OrderedRecords[shape][color].toyNumbers;
                }
                PrintRow(shape, QuantitiyOfShape.ToString());
            }
            PrintLine();
        }
        public void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }


    }
}
