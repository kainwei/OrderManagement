using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class InvoiceReport : Order
    {
        public int tableWidth = 73;
        public InvoiceReport(string customerName, string customerAddress, string dueDate, Dictionary<string, Dictionary<String, Toy>> OrderedRecords)
        {
            base.CustomerName = customerName;
            base.Address = customerAddress;
            base.DueDate = dueDate;
            base.OrderedRecords = OrderedRecords;
        }

        public override void GenerateReport()
        {
            Console.WriteLine("\nYour invoice report has been generated: ");
            Console.WriteLine(base.ToString());
            GenerateTable();
            OrderToyDetail();
            RedPaintSurcharge();
        }

        public void RedPaintSurcharge()
        {
            Console.WriteLine("Red Color Surcharge       " + TotalAmountOfRedShapes() + " @ $" + base.OrderedRecords["Circle"]["Red"].toyColor.AdditionalCharge + " ppi = $" + TotalPriceRedPaintSurcharge());
        }

        public int TotalAmountOfRedShapes()
        {
            return base.OrderedRecords["Circle"]["Red"].toyNumbers + base.OrderedRecords["Square"]["Red"].toyNumbers +
                   base.OrderedRecords["Triangle"]["Red"].toyNumbers;
        }

        public int TotalPriceRedPaintSurcharge()
        {
            return TotalAmountOfRedShapes() * base.OrderedRecords["Circle"]["Red"].toyColor.AdditionalCharge;
        }


        public void GenerateTable()
        {
            PrintLine();
            PrintRow("        ", "   Red   ", "  Blue  ", " Yellow ");
            PrintLine();
            foreach(string shape in OrderedRecords.Keys)
            {
                PrintRow(shape, base.OrderedRecords[shape]["Red"].toyNumbers.ToString(), base.OrderedRecords[shape]["Blue"].toyNumbers.ToString(), base.OrderedRecords[shape]["Yellow"].toyNumbers.ToString());
            }
            PrintLine();
        }

        public void OrderToyDetail()
        {
            foreach (string shape in OrderedRecords.Keys)
            {
                int QuantitiyOfShape = 0;
                foreach(string color in OrderedRecords[shape].Keys)
                {
                    QuantitiyOfShape += OrderedRecords[shape][color].toyNumbers;
                }
                int shapePrice = OrderedRecords[shape]["Red"].toyShape.Price;
                int shapesPrice = QuantitiyOfShape * shapePrice;
                Console.WriteLine("\n" + shape + " 		  " + QuantitiyOfShape + " @ $" + shapePrice + " ppi = $" + shapesPrice);
            }
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
