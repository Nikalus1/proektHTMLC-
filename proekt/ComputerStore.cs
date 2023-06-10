using System;
using System.Collections.Generic;
using System.Linq;

namespace proekt
{
    public class ComputerStore : IComputerStore
    {
        public List<Device> Devices { get; set; }

        public double CalculateInventoryValue()
        {
            double inventoryValue = Devices.Sum(device => device.Price * device.AvailableQuantity);
            return inventoryValue;
        }

        public ComputerStore()
        {
            Devices = new List<Device>();
        }

        public void AddDevice(Device device)
        {
            Devices.Add(device);
        }

        public void PrintDevices()
        {
            foreach (var device in Devices)
            {
                Console.WriteLine($"Устройство: {device.Name}");
                Console.WriteLine($"Цена: {device.Price:C2}");
                Console.WriteLine($"Ново/Втора употреба: {(device.IsNew ? "Ново" : "Втора употреба")}");
                Console.WriteLine($"Налични бройки: {device.AvailableQuantity}");
                Console.WriteLine($"Търсени бройки: {device.RequiredQuantity}");
                Console.WriteLine();
            }
        }
      



        public void PrintMostExpensiveDevice()
        {
            if (Devices.Count > 0)
            {
                Device mostExpensiveDevice = Devices.OrderByDescending(d => d.Price).First();
                Console.WriteLine("Най-скъпото устройство:");
                Console.WriteLine($"Име: {mostExpensiveDevice.Name}");
                Console.WriteLine($"Цена: {mostExpensiveDevice.Price:C2}");
                Console.WriteLine($"Ново/Втора употреба: {(mostExpensiveDevice.IsNew ? "Ново" : "Втора употреба")}");
                Console.WriteLine($"Налични бройки: {mostExpensiveDevice.AvailableQuantity}");
                Console.WriteLine($"Търсени бройки: {mostExpensiveDevice.RequiredQuantity}");
            }
            else
            {
                Console.WriteLine("Магазинът няма устройства.");
            }
        }
        public void EnterDeviceData()
        {
            Console.WriteLine("Въвеждане на данни за ново устройство:");
            Console.Write("Име: ");
            string name = Console.ReadLine();

            Console.Write("Цена: ");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price) || price <= 0)
            {
                Console.WriteLine("Невалидна цена. Моля, въведете положително число.");
                Console.Write("Цена: ");
            }

            Console.Write("Налични бройки: ");
            int availableQuantity;
            while (!int.TryParse(Console.ReadLine(), out availableQuantity) || availableQuantity < 0)
            {
                Console.WriteLine("Невалиден брой налични бройки. Моля, въведете цяло число, по-голямо или равно на нула.");
                Console.Write("Налични бройки: ");
            }

            Console.Write("Търсени бройки: ");
            int requiredQuantity;
            while (!int.TryParse(Console.ReadLine(), out requiredQuantity) || requiredQuantity < 0)
            {
                Console.WriteLine("Невалиден брой търсени бройки. Моля, въведете цяло число, по-голямо или равно на нула.");
                Console.Write("Търсени бройки: ");
            }

            var device = new NewDevice(name, price, availableQuantity, requiredQuantity);
            AddDevice(device);
            Console.WriteLine("Устройството е успешно добавено.");
        }
    }
}
