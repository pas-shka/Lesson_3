using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace CarPark
{
    class ParkReport 
    {
        public int CostPark(List<Car> Park)
        {
            int allSum = 0;
            foreach (var a in Park)
            {
                allSum += a.Price;
            }
            return allSum;
        }

        public void SortFuelUsed(List<Car> Park)
        {
            Dictionary<int, int> Fuel = new Dictionary<int, int>();
            for (int i = 0; i < Park.Count; i++)
            {
                Fuel.Add(Park[i].IdCar, Park[i].FuelUsed);
            }

            //var sorted = Fuel.OrderBy(x => x.Value);    
            //foreach (var a in sorted)
            //{
            //    Console.WriteLine(a);
            //}

            var sortedDict = from entry in Fuel orderby entry.Value ascending select entry;
            foreach (var a in sortedDict)
            {
                foreach (var b in Park)
                {
                    if (b.IdCar == a.Key)
                    {
                        Console.WriteLine(b.Name);
                    }
                }
            }

            //var sorted = Fuel.ToList();
            //sorted.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            //foreach (var a in sorted)
            //{
            //    Console.WriteLine(a);
            //}


        }

        public void SpeedRange(List<Car> Park, string diap)
        {
            string[] ranges = diap.Split('-');
            int minDiap = Convert.ToInt32(ranges[0]);
            int maxDiap = Convert.ToInt32(ranges[1]);
            foreach (var aCar in Park)
            {
                if (minDiap <= aCar.MaxSpeed && maxDiap >= aCar.MaxSpeed)
                {
                    Console.WriteLine(aCar.Name);
                }
            }
        }
    }
}
