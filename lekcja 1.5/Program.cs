
using System;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {


            //    Console.WriteLine("Hello World");

            //   int x = 123;
            // bool b = Convert.ToBoolean(x);
            //   Console.WriteLine(b);

            int liczba = 123;
            int liczbaB = 67;
            byte b = Convert.ToByte(liczba);
            Console.WriteLine(b);
            char c = Convert.ToChar(liczba);
            Console.WriteLine(c);
            decimal dx = Convert.ToDecimal(liczba);
            Console.WriteLine(dx);
            double dblx = Convert.ToDouble(liczba);
            Console.WriteLine(dblx);
            int ix = Convert.ToInt32(dblx);
            Console.WriteLine(ix);
            string str = Convert.ToString(liczba + liczbaB / 3);
            Console.WriteLine(str);

            int a = 1;
            //String str2 = (String)a;
            float fa = (float)a;


            var j = 101;


        }






    }
}



