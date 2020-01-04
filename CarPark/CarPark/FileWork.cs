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

        public List<ICarICE> ReadFile(string pathRead)
        {
            List<ICarICE> Park = new List<ICarICE>();

            using (StreamReader sr = new StreamReader(pathRead))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    lineSplit = line.Split('|');
                    if (lineSplit[0]=="p" || lineSplit[0] == "P")
                    {
                        Park.Add(new PassengerCar(Convert.ToInt32(lineSplit[1]), lineSplit[2],
                            Convert.ToInt32(lineSplit[3]), Convert.ToInt32(lineSplit[4]), Convert.ToInt32(lineSplit[5]),
                            Convert.ToInt32(lineSplit[6]), Convert.ToBoolean(lineSplit[7])));

                    }
                    if (lineSplit[0] == "m" || lineSplit[0] == "M")
                    {

                    }
                }
            }
            
            return Park;
        }
    }
}
