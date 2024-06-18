using System;

namespace _9.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 }; // luckyNumber is a container saves the value, [] means array  and the values are saved in { }   


            Console.WriteLine(luckyNumbers[0]);  // index 0 is 4  index 1 is 8 and follows 

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]); // we have updated the number for this so it will display 900




            Console.ReadLine();

            /*

            string[] friends = new string[5]; // we can select the array  // this is another way to create an array 
            friends[0] = "Kim";
            friends[1] = "JIm";   // we can add so on 
            */

        }
    }
}
