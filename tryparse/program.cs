using System;

namespace Lekcja0604
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TryParse!");
            String[] values = {
                null, "234","98.3","23,99",
                "-34","+34","(100)","01FA"
            };

            foreach (var value in values)
            {
                int number;
                bool success = Int32.TryParse(value, out number);
                if (success)
                {
                    Console.WriteLine("Parsowanie okej");
                }
                else
                {
                    Console.WriteLine("Parsowanie nie okej");
                }
            }





        }
    }
}
