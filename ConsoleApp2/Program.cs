using System;

namespace Lekcja0704
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Hello World!");

            double dx = 354.34;
            bool res = double.IsInfinity(dx);
            if (res == true)
            {
                Console.WriteLine("Ta wartość jest dodatanią lub" + "ujemną nieskończonością");
                    
            }
            else
            {
                Console.WriteLine("Ta wartość jest liczbą skończoną");
            }
        }
    }
}
