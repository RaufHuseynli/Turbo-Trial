using System;
using Turbo.az.Car_and_extends;
using Turbo.az.Manager;

namespace Turbo.az
{
    class Program
    {
        static void Main(string[] args)
        {

            AnnouncementManager nw = new AnnouncementManager();
            AnnouncementManager.AnnounceManager();


        }
        public static void menu()
        {
            Console.WriteLine("1.Markanizi qeyd ediniz : ");
            Console.WriteLine("2. Modelinizi qeyd ediniz : ");
            Console.WriteLine("3.Istehsal tarixini qeyd ediniz: ");
            Console.WriteLine("4.Ban tipini qeyd ediniz: ");
            Console.WriteLine("5.Rengini qeyd ediniz: ");
            Console.WriteLine("6.Mator hecmini qeyd ediniz: ");
            Console.WriteLine("7.At gucunu qeyd ediniz: ");
            Console.WriteLine("8.Yanacag tipini qeyd ediniz: ");
            Console.WriteLine("9.Yuruyusunu qeyd ediniz: ");
            Console.WriteLine("10.Oturucunu qeyd ediniz: ");
            Console.WriteLine("11.Suretler qutusunu qeyd ediniz: ");
            Console.WriteLine("12. Qiymetini qeyd ediniz: ");
            int secim = int.Parse(Console.ReadLine());
            if(secim == 1)
            {

            }

        }
    }
}
