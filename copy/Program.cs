using System;

namespace Lekcja13
{

    class Program
    {

        static void Main(string[] args)
        {

            int[] iarr = new int[5] { 1, 2, 3, 4, 5 };                      //building a array
            Object[] oarr = new Object[5] { 45, 46, 47, 48, 49 };
            Console.WriteLine("Tablica warotości typu int");
            DisplayArr(iarr);
            Console.WriteLine("Tablica typu Object: ");
            DisplayArr(oarr);

            System.Array.Copy(oarr, oarr.GetUpperBound(0) - 1, iarr,
                iarr.GetUpperBound(0) - 1, 2);

            Console.WriteLine("Postac tablic po kopiowaniu");
            Console.WriteLine("Tablica typu int");
            DisplayArr(iarr);


        }
        public static void DisplayArr(Object[] arr)
        {
            foreach (Object i in arr)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine();

        }
        public static void DisplayArr(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine("\t{0}", i);
            }
            Console.WriteLine();
        }


    }
}