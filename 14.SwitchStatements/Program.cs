using System;

namespace _14.SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0));   // apply different number and try 
        }
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;                      // we need break; because if it matches the case num it will stop here 
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "tuesday";
                    break;
                case 3:
                    dayName = "Wedday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;


            }


            return dayName;

        }


    }
}
