using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Turbo.az.Enum;

namespace Turbo.az.Manager
{
    public  class AnnouncementManager
    {
        public static void AnnounceManager()
        {
            Announcement announcement = new Announcement();
            Console.Write("Elan tipini seciniz: Telefon nomresi ile(1), Biznes Hesabi ile(2): ");
            int choosen = Convert.ToInt32(Console.ReadLine());
           



            if(choosen == (int)AccountType.ContactNumber)
            {

                Console.Write("Nomrenizi daxil ediniz: ");
                string number =  Console.ReadLine();
                Console.WriteLine("Nomrenize gelen kod yoxlanilir");

                Thread.Sleep(2000);

                Random rnd = new Random();

                int confirmCode = rnd.Next(1000, 9999);

                Console.WriteLine($"Sizin tesdiqleme kodunuz: {confirmCode}");
                Console.WriteLine("Ugurla qeydiyatdan kecdiniz");

            }
            else if(choosen == (int)AccountType.Business)
            {
                ContactofSeller contactofSeller = new ContactofSeller();
                Console.Write("Email ve sifrenizi daxil ediniz: ");
                contactofSeller.Email = Console.ReadLine();
                contactofSeller.Password = Console.ReadLine();

            }
            Car car = new Car();

            Console.WriteLine("Markasini daxil edin: ");
            car.Marka = Console.ReadLine();
            Console.WriteLine("Modelini daxil edin: ");
            car.Model = Console.ReadLine();
            Console.WriteLine("Istehsal tarixini daxil ediniz: ");
            car.YearofProduction = Console.ReadLine();
            Console.WriteLine("Ban tipini daxil ediniz: ");
            car.BanType = Console.ReadLine();
            Console.WriteLine("Rengini daxil ediniz: ");
            car.Colour = Console.ReadLine();
            Console.WriteLine("Muherrik hecmini daxil ediniz: ");
            car.EngineVolume = Console.ReadLine();
            Console.WriteLine("At gucunu daxil ediniz: ");
            car.HorsePower = Console.ReadLine();
            Console.WriteLine("Yanacag tipini daxil ediniz: ");
            car.TypeofFuel = Console.ReadLine();
            Console.WriteLine("Yuruyusunu daxil ediniz: ");
            car.Mileage = Console.ReadLine();
            Console.WriteLine("Suretler qutusunu daxil ediniz: ");
            car.Gearbox = Console.ReadLine();
            Console.WriteLine("Oturucusunu daxil ediniz: ");
            car.Transmitter = Console.ReadLine();
            Console.WriteLine("Qiymetini daxil ediniz: ");
            car.Price = Console.ReadLine();
            Console.WriteLine("Yuklenir ...");
            Random rndm = new Random();
            int confirmmCode = rndm.Next(10000, 50000);
            Thread.Sleep(2000);
            Console.WriteLine("Elan tesdiqlendi . Elan kodunuz : " + confirmmCode);




        }



    }
}
