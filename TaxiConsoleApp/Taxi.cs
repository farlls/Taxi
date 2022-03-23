using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiConsoleApp
{
    class Taxi
    {
        public string DriverName { get; set; }
        public int NumPassangger { get; set; }
        public bool OnDuty { get; set; }
           
        public void TaxiInfo()
        { 
            string result = (OnDuty == true) ? "Yes" : "No";
            Console.WriteLine("Nama Driver : {0}", DriverName);
            Console.WriteLine("OnDuty : {0}", result);
            Console.WriteLine("Number Of Passangger : {0}\n", NumPassangger);
        }
        public void PickUpPassangger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
        }
        public void DropOffPassangger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", DriverName);
        }




    }
}
