using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FileWork a = new FileWork();
 
            ParkReport b = new ParkReport();
            b.SpeedRange(a.ReadFile("../1.txt"), "100-2000");
            
            Console.ReadKey();
        }
    }
}
