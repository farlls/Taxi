using System;

namespace TaxiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
            taxi.DriverName = "Farrel";
            taxi.OnDuty = true;
            taxi.NumPassangger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassangger();
            taxi.DropOffPassangger();
            Console.ReadKey();

        }
    }
}
