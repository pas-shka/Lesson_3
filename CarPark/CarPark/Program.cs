﻿using System;
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
            Console.WriteLine(b.CostPark(a.ReadFile("../1.txt")));
            
            Console.ReadKey();
        }
    }
}
