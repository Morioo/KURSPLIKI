using System;

namespace Lekcja0702
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("identyczność wartości double!");

            double d1 = 0.3333333;
            double d2 = (double)1 / 3;
            Console.WriteLine(d1.Equals(d2));
        }


    }








}
