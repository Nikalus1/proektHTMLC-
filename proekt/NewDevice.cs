using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    internal class NewDevice:Device
    {
        public NewDevice(string name, double price, int availableQuantity, int requiredQuantity)
        : base(name, price, true, availableQuantity, requiredQuantity)
        {
        }

        
        public override double CalculateInventoryValue()
        {
            return Price * AvailableQuantity;
        }
    }
}
