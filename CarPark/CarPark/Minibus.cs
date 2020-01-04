using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class Minibus : ICarICE
    {
        public int IdCar { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public int Price { get; set; }
        public int FuelUsed { get; set; }
        public int MaxSpeed { get; set; }

        public  int Сarrying { get; set; }
    }
}
