using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    internal class UsedDevice:Device
    {
        public UsedDevice(string name, double price, int availableQuantity, int requiredQuantity)
        : base(name, price, false, availableQuantity, requiredQuantity)
        {
        }


        public override double CalculateInventoryValue()
        {
            return Price * AvailableQuantity * 0.5;
        }
    }
}
