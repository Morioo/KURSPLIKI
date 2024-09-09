using System;

namespace Lekcja0706
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");


            double dx = -4.5;
            bool res = double.IsNegative(dx);
            if (res == true)
            {
                Console.WriteLine("ta wartość jest ujemna");

            }

            else
            {

                Console.WriteLine("ta wartość jest dodatnia");
            }
        }
    }
}
