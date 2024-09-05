using System;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {





            int[] tnum1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("{0} ", tnum1[1]);s

            }
            Console.WriteLine("**********");

            Console.WriteLine("Usuniecie od 2 do 5");

            Array.Clear(tnum1, 2, 5);
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("{0} ", tnum1[i]);

            }
            Console.WriteLine("Teraz zerowanie 5 elementów");
                Array.Clear(tnum2, 2, 5);











        }
    }
}