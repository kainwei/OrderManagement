using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Triangle : Shape
    {
        public int TrianglePrice = 2;

        public Triangle()
        {
            Name = "Triangle";
            base.Price = TrianglePrice;
        }
    }
}
