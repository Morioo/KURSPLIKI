using System;
using System.Collections.Generic;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {
            //Method add range
            String[] input = { "Masło", "Chleb", "Jajka" };
            List<string> foods = new List<string>(input);    //creating a list
            Console.WriteLine("Pojemnosc: {0}", foods.Capacity);

            foreach (String food in foods)
            {
                Console.WriteLine(food);
            }
            foods.AddRange(foods);
            Console.WriteLine("******");

            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }



        }



    }
}