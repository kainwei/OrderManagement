using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Circle : Shape
    {
        public int circlePrice = 3;

        public Circle()
        {
            Name = "Circle";
            base.Price = circlePrice;
        }
    }
}
