using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Lekcja13
{
    public class StringKeekper
    {
        private string[] strArr = new string[10];
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("index out od range");
                return strArr[index];


            }
            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("index out Of range");
                strArr[index] = value;


            }



        }


    }
    class Program
    {

        static void Main(string[] args)
        {

            StringKeekper strkeeper = new StringKeekper();
            strkeeper[0] = "Kasia";
            strkeeper[1] = "Jagoda";




        }
    }
}