using System;
using System.Collections.Generic;

namespace Order.Management
{
    class Program
    {
        // Main entry

       
        static void Main(string[] args)
        {
           
            var (customerName, address, dueDate) = CustomerInfoInput();

            var orderedRecords = OrderToyInput();

            InvoiceReport(customerName, address, dueDate, orderedRecords);

            CuttingListReport(customerName, address, dueDate, orderedRecords);

            PaintingReport(customerName, address, dueDate, orderedRecords);
        }
        

        public static  Dictionary<string, Dictionary<String, Toy>> OrderToyInput()
        {
            Dictionary<string, Dictionary<String, Toy>> OrderedRecords = new Dictionary<string, Dictionary<String, Toy>>();
            
            List<List<string>> inputlist = new List<List<string>>();

            List<string> circlelist = new List<string>();
            Console.Write("\nPlease input the number of Red Circle: ");
            List<string> sublist = new List<string> {"Circle", "Red", userInput()};
            inputlist.Add(sublist);

            Console.Write("Please input the number of Blue Circle: ");
            sublist = new List<string> { "Circle", "Blue", userInput() };
            inputlist.Add(sublist);

            Console.Write("Please input the number of Yellow Circle: ");
            sublist = new List<string> { "Circle", "Yellow", userInput()};
            inputlist.Add(sublist);

            Console.Write("\nPlease input the number of Red Squares: ");
            sublist = new List<string> { "Square", "Red", userInput() };
            inputlist.Add(sublist);

            Console.Write("Please input the number of Blue Squares: ");
            sublist = new List<string> { "Square", "Blue", userInput() };
            inputlist.Add(sublist);

            Console.Write("Please input the number of Yellow Squares: ");
            sublist = new List<string> { "Square", "Yellow", userInput() };
            inputlist.Add(sublist);

            Console.Write("\nPlease input the number of Red Triangles: ");
            sublist = new List<string> { "Triangle", "Red", userInput() };
            inputlist.Add(sublist);

            Console.Write("Please input the number of Blue Triangles: ");
            sublist = new List<string> { "Triangle", "Blue", userInput() };
            inputlist.Add(sublist);

            Console.Write("Please input the number of Yellow Triangles: ");
            sublist = new List<string> { "Triangle", "Yellow", userInput() };
            inputlist.Add(sublist);

            foreach(List<string> toylist in inputlist )
            {
                int number = Convert.ToInt32(toylist[2]);
                string shape = toylist[0];
                string color = toylist[1];
                Toy toy = new Toy(number, shape, color);
                if(OrderedRecords.ContainsKey(shape))
                {
                    OrderedRecords[shape][color] = toy;
                }
                else
                {
                    Dictionary<String, Toy> colorDic = new Dictionary<string, Toy>();
                    colorDic[color] = toy;
                    OrderedRecords[shape] = colorDic;
                }
            }
            return OrderedRecords;
        }
        // Order Circle Input
        

        // User Console Input
        public static string userInput()
        {
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("please enter valid details");
                input = Console.ReadLine();

            }
            return input;
        }

        // Generate Painting Report 
        private static void PaintingReport(string customerName, string address, string dueDate, Dictionary<string, Dictionary<String, Toy>> OrderedRecords)
        {
            PaintingReport paintingReport = new PaintingReport(customerName, address, dueDate, OrderedRecords);
            paintingReport.GenerateReport();
        }

        // Generate Painting Report 
        private static void CuttingListReport(string customerName, string address, string dueDate, Dictionary<string, Dictionary<String, Toy>> OrderedRecords)
        {
            CuttingListReport cuttingListReport = new CuttingListReport(customerName, address, dueDate, OrderedRecords);
            cuttingListReport.GenerateReport();
        }

        // Generate Invoice Report 
        private static void InvoiceReport(string customerName, string address, string dueDate, Dictionary<string, Dictionary<String, Toy>> OrderedRecords)
        {
            InvoiceReport invoiceReport = new InvoiceReport(customerName, address, dueDate, OrderedRecords);
            invoiceReport.GenerateReport();
        }

        // Get customer Info
        private static (string customerName, string address, string dueDate) CustomerInfoInput()
        {
            Console.Write("Please input your Name: ");
            string customerName = userInput();
            Console.Write("Please input your Address: ");
            string address = userInput();
            Console.Write("Please input your Due Date: ");
            string dueDate = userInput();
            return (customerName, address, dueDate);
        }
       
    }
}
