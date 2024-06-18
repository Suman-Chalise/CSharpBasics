using System;

namespace _10.Methods_Functions_
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();                     // calling the method in main method to execute 
            //Console.ReadLine();

            // main on top here is Method 
            
        }
        // we now trying outside Main method
        static void SayHi()             // creating a method called SayHi()
        {
            Console.WriteLine("Hello user");
        }

        //Note - method in c# is also known as function so it is same as function 

        // another way for creating method below - 
        /*

        static void SayHi(string name)             // specifying string name 
        {
            Console.WriteLine("Hello" + name);
        }
        */

        // also there is another way to add method 

        /*
             class Program
    {
        static void Main(string[] args)
        {

            SayHi("Suman", 30);   // we need to specify string and int 
            SayHi("Adam", 55);
            SayHi("Amo", 19);

            Console.ReadLine();


        }

        static void SayHi(string name, int age)             // specifying string name and age// We can have 2 parameters as well in method 
        {
            Console.WriteLine("Hello" + name + " you are " + age);
        }


    }
         */

       


    }
}
