using System;
using System.Collections.Generic;
using System.Text;

namespace Order.Management
{

    
    class Red : Color
    {
        public int AC = 1;
        public Red()
        {
            Name = "Red";
            base.AdditionalCharge = AC;
        }
       
    }
}
