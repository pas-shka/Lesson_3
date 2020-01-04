using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class FileWork
    {
        private string textAll;
        private string line;
        private string[] lineSplit;

        public List<Car> ReadFile(string pathRead)
        {
            List<Car> Park = new List<Car>();

            using (StreamReader sr = new StreamReader(pathRead))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    lineSplit = line.Split('|');
                    Park.Add(new Car(Convert.ToInt32(lineSplit[0]), lineSplit[1], Convert.ToInt32(lineSplit[2]), Convert.ToInt32(lineSplit[3]), Convert.ToInt32(lineSplit[4]), Convert.ToInt32(lineSplit[5]), lineSplit[6]));
                }
            }
            
            return Park;
        }
    }
}
