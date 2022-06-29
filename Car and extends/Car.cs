using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
   interface Car: Vehicle // ID'nin kod verilmesinde problem!
    {
        
        public string Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int YearofProduction { get; set; }
        public string  BanType { get; set; }
        public string  Colour { get; set; }
        public double EngineVolume { get; set; }
        public int HorsePower { get; set; }
        public string TypeofFuel { get; set; }
        public int Mileage { get; set; }
        public string  Gearbox { get; set; }
        public string Transmitter { get; set; }
        public int Price { get; set; }
        object CustomIDGenerator { get; }
    }
}
