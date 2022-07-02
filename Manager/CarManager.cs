using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az.Manager
{
    public class CarManager
    {
        public static void carManager()
        {
         Car car = new Car();
        Console.WriteLine(" Neqliyyat vasitenin markasini qeyd ediniz :  ");
        car.Marka = Console.ReadLine();
        Console.WriteLine("Neqliyyat vasitenin modelini qeyd edin : ");
        car.Model = Console.ReadLine();
        }
      

    }
}
