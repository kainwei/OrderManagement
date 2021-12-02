using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Square : Shape
    {

        public int SquarePrice = 1;

        public Square()
        {
            Name = "Square";
            base.Price = SquarePrice;
        }
    }
}
