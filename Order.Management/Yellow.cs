using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Yellow : Color
    {
        public int AC = 0;
        public Yellow()
        {
            Name = "Yellow";
            base.AdditionalCharge = AC;
        }

    }
}
