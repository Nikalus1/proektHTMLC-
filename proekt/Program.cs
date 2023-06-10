using proekt;
using System;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ComputerStore computerStore = new ComputerStore();
            

            Console.WriteLine("Въвеждане на данни за нови устройства:");
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                computerStore.EnterDeviceData();
            }


            Console.WriteLine("Въвеждане на данни за употребявани устройства:");
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                computerStore.EnterDeviceData();
            }



            Console.WriteLine("Устройства в магазина:");
            computerStore.PrintDevices();

            Console.WriteLine();

            

            double inventoryValue = computerStore.CalculateInventoryValue();
            Console.WriteLine($"Стойност на наличностите: {inventoryValue:C2}");




        }
    }
}