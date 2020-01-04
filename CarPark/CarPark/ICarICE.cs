using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    interface ICarICE
    {
        int IdCar { get; set; }
        string Name { get; set; }
        int Volume { get; set; }
        int Price { get; set; }
        int FuelUsed { get; set; }
        int MaxSpeed { get; set; }
    }
}
