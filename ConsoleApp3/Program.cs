using System;

namespace Lekcja0705
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double dx = 34.43;
            bool res = double.IsNaN(dx);
            if (res == true)
            {
                Console.WriteLine("Ta wartość nie jest liczba");
            }
            else
            {
                Console.WriteLine("Ta wartość jest liczbą");
            }
        }

    }

}
