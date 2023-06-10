using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    public class DeviceQuantityComparer:IComparer<Device>
    {
        public int Compare(Device x, Device y)
        {
            return x.AvailableQuantity.CompareTo(y.AvailableQuantity);
        }
    }
}
