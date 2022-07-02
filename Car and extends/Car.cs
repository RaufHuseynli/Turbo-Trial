using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az
{
  public class Car: Vehicle 
    {
        
       
        public string Marka { get; set; }
        public string Model { get; set; }
        public string YearofProduction { get; set; }
        public string  BanType { get; set; }
        public string  Colour { get; set; }
        public string EngineVolume { get; set; }
        public string HorsePower { get; set; }
        public string TypeofFuel { get; set; }
        public string Mileage { get; set; }
        public string  Gearbox { get; set; }
        public string Transmitter { get; set; }
        public string Price { get; set; }
        object CustomIDGenerator { get; }
    }
}
