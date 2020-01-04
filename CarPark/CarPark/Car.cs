using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class Car 
    {
        public int IdCar { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }
        public int Price { get; set; }
        public int FuelUsed { get; set; }
        public int MaxSpeed { get; set; }
        public string Category { get; set; }

        public Car() { }

        public Car(int idCar, string name, int volume, int price, int fuelUsed, int maxSpeed, string category)
        {
            this.IdCar = idCar;
            this.Name = name;
            this.Volume = volume;
            this.Price = price;
            this.FuelUsed = fuelUsed;
            this.MaxSpeed = maxSpeed;
            this.Category = category;
        }
    }
}
