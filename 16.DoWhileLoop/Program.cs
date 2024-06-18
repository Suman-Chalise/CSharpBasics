using System;

namespace _16.DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int index = 11;   // here value 11 
            do
            {
                Console.WriteLine(index);
                index++;

            } while (index <= 10);  // index is more than 10 so it will not run, the code is run before this condition so it will print that index and stops 

            Console.ReadLine(); ;
        }
    }
}

// for this loop we will run the code first and only check the condition. 
//Where as on While loop we will check the condition first and only run the code
