using System;
using System.ComponentModel;

namespace _3.DataType
{
    class Program
    {
        static void Main(string[] args)
        {

            //string phrase = "Giraffe Academy";  // sring contains characters like plain text
            //char grade = 'A';                  // char only allowed one character . if you need more character then use string 

            //int age = 30;                    // int no do not need double quotes, we can use - numbers as well 
            ////float, double, decimal          // accurate data please use decimal // double is also usable 
            //double gpa = 3.3;

            //bool isMale = true;          // true or false value only 

            //// so mostly used datatypes are int, string, float, double 
         


            string test = "Suman"; 
            if (args.Length >= 2)
            {

                string secondArgument = args[1];


                Console.WriteLine($"{ secondArgument}");
            }
            else
            {
                Console.WriteLine($"{test}");
            }


        }
    }
}
