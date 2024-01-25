using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car() { }

        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDrivable) 
        
        {
            Make = make;
            Model = model;  
            Year = year;    
            EngineNoise = engineNoise;  
            HonkNoise = honkNoise;
            IsDriveble = isDrivable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveble { get; set; }

        public void MakeEgineNoise(string noise)
        {
            Console.WriteLine($"The {Make}'s engine noise goes {noise}");
        }
        public void MakeHonkNoise(string noise)
            {
                Console.WriteLine($"The {Make}'s honk noise goes {HonkNoise}");
            }


    }
}
