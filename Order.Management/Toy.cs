using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Toy
    {
        public Shape toyShape;
        public Color toyColor;
        public int toyNumbers;
        
        public Toy(int number, string shape, string color)
        {

            toyNumbers = number;

            switch (color)
            {

                case "Red":
                    toyColor = new Red();
                    break;

                case "Blue":
                    toyColor = new Blue();
                    break;

                case "Yellow":
                    toyColor = new Yellow();
                    break;

                default:
                    Console.WriteLine("please enter valid colors");
                    break;

            }

            switch (shape)
            {

                case "Circle":
                    toyShape = new Circle();
                    break;

                case "Square":
                    toyShape = new Square();
                    break;

                case "Triangle":
                    toyShape = new Triangle();
                    break;

                default:
                    Console.WriteLine("please enter valid shapes");
                    break;

            }
        }

        public int Total()
        {
            return (this.toyNumbers * this.toyShape.Price);
        }



    }
}
