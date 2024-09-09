using System;

namespace Lekcja0703
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");

            double dx = 354.54;
            bool result = double.IsFinite(dx);
            if (result == true)                        //
            {
                Console.WriteLine("ta wartość jest skończona");
            }
            else
            {
                Console.WriteLine("ta wartość nie jest skończona");
            }
        }



    }
}
