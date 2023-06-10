using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    public abstract class Device
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public int AvailableQuantity { get; set; }
        public int RequiredQuantity { get; set; }

        public Device(string name, double price, bool isNew, int availableQuantity, int requiredQuantity)
        {
            Name = name;
            Price = price;
            IsNew = isNew;
            AvailableQuantity = availableQuantity;
            RequiredQuantity = requiredQuantity;
        }
        public abstract double CalculateInventoryValue();

        
    }
}
