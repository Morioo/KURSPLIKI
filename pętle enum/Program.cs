
using System;

public enum NetEnums
{

    Facebook,
    linkedin,
    Twitter,
    Instagarm

}

enum DaysOfWeek
{
    Mondey,
    tuseday,
    Wednesday,
    Thrusday,
    Friday,
    Saturday,
    sunday

}


class program
{

    static void Main(string[] args)
    {


        foreach (var name in Enum.GetNames(typeof(NetEnums)))
        {

            Console.WriteLine(name);


        }
        foreach (var val in Enum.GetValues(typeof(NetEnums)))
        {

            Console.WriteLine((int)val);
        }

    }
    //Conversion string to enum








}
