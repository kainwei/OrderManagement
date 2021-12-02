using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{
    class Blue : Color
    {
        public int AC = 0;
        public Blue()
        {
            Name = "Blue";
            base.AdditionalCharge = AC;
        }

    }
}
