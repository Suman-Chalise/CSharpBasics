using System;

namespace _13.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.Write("please enter a number : ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Operator : ");
                string op = Console.ReadLine();

                Console.Write("Please enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (op == "+")
                {
                    Console.WriteLine(num1 + num2);

                }
                else if (op == "-")
                {
                    Console.WriteLine(num1 - num2);
                }
                else if (op == "/")
                {
                    Console.WriteLine(num1 / num2);
                }
                else if (op == "*")
                {
                    Console.WriteLine(num1 * num2);
                }
                else
                {
                    Console.WriteLine("you have entered invalid operator! ");
                }

                Console.ReadLine();

            }
        }
    }
}
