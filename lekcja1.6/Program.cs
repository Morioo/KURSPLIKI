using System;
using System.ComponentModel.Design;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Hello World");

            /*
             
             Znaki

            +
            -
            /
            *
            %
            =
            >
            <
            ==  porównianie  np. jeżeli x jest równy 2  if (x==2);
            && (Takie i np.) if (x>2 && < 4);
            || co najmniej jedna rzecz musi być spełniona  (x>2 || < 1);
            >=
            <=




            // x = x + x * y In the order, first multiplication, then addition (unless brackets)!
            //
            x = (x + x) * y
             




            preinkrementacja :
            ++x, --x

            dekrementacja :
            x++, x--
             




            if (x==2)
            if (x>2) instrukcja
            if (x<2) instrukcja
            if (x>5 && < 7);
            if (x<2 || x>4)
             
             
             
             
             
             
             
             
             */

            //Console. ReadLine()  User replies!

            Console.WriteLine(3 + 4 * 5 / 2 + 3 ^ 3);

            int y = 0;
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;

            Console.WriteLine("Podaj x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj x3: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            y = x1 + x2 * x3;
            Console.WriteLine("Wynik: {0}", y);

            y = (x1 + x2) * x3;
            Console.WriteLine("Wynik to {0}", y);

            y = x1 + x2 * x3 * x2 / x1;
            Console.WriteLine("Wynik to {0}", y);





            //relationship operators
            y = x1 + x2 + x3;

            if (y == 3)
            {

                Console.WriteLine("To jest 3");




            }
            else
            {

                Console.WriteLine("BUUUUU ŹLE");

            }
















        }







    }

}

