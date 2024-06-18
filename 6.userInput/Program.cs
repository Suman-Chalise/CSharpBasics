using System;

namespace _6.userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();  // Stores the value in to variable name 
            // Console.WriteLine("Hello "+ name);
            Console.Write("enter your age? ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " your age is " + age);
            Console.ReadLine();

            //            int num = Convert.ToInt32("54");   // ToInt32 will conver strings to integer. we can see all optoons after convert.
            // Console.WriteLine(num + 6);

            Console.Write("What is your nam?\n");
            string nam = Console.ReadLine();
            Console.Write("what is your age\n");
            int age1 = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("your name is " + nam + " And your age is " + age1);
            Console.ReadLine();


        }
    }
}
