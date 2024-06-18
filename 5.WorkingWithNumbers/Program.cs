using System;

namespace _5.WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(50);
            Console.WriteLine(5 + 8);  // it will print out the result
            Console.WriteLine(5 - 8);  // it will do all basic maths
            Console.WriteLine(5 % 2);  // it will only gives remainder which is 1 
            Console.WriteLine(4 + 2 * 3);  // it will follow the rules of order 
            Console.WriteLine((4 + 2) * 3); // we can select which operation to do first 


            Console.WriteLine(5.0 + 8.1);  // it will gives right result 
            Console.WriteLine(5 + 8.1);
            Console.WriteLine(5 / 2); // it will print integer 2 only 
            Console.WriteLine(5 / 2.0); // we will received decimal back and result which is 2.5

            int num = 6;
            Console.WriteLine(num);

            int num1 = 6;
            num1++; // it will add 1 number whihch will be 7 
            Console.WriteLine(num1);

            int num2 = 6;
            num2--; // it will minus 1 number whihch will be 5
            Console.WriteLine(num2);

            Console.WriteLine(Math.Abs(-40));  // absolute value// it will gives 40
            Console.WriteLine(Math.Pow(3, 2)); // it will be power and 3 x 3 = 9 result
            Console.WriteLine(Math.Pow(3.8, 2));

            Console.WriteLine(Math.Sqrt(36)); // we will get the square root of 36 which will be 6 

            Console.WriteLine(Math.Max(4, 40)); // answer will be 40 Max number 

            Console.WriteLine(Math.Round(4.3)); // answer will be 4 
            Console.WriteLine(Math.Round(4.6)); // answer will be 5 
            Console.ReadLine();
        }
    }
}
