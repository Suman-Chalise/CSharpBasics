using System;

namespace _4.WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("giraffe\n Academy");  // \n will display rest in another line
            Console.WriteLine("giraffe\" Academy");  // this \" to add quotation on 


            string name1 = "Suman chalise";
            Console.WriteLine(name1 + "hello"); // it will concenated variable name1 and string hello together
            Console.WriteLine(name1.Length);  // .length will give how many character in varible name1 "Suman" which is 5 

            Console.WriteLine(name1.ToUpper());  // change value in variable to uppdercase 
            Console.WriteLine(name1.ToLower()); // change value in variable to lowercase 

            Console.WriteLine(name1.Contains("Suman")); // it will check is Suman is in variable and return true or false // it returns true
            Console.WriteLine(name1.Contains("pokhara")); // it wil return false

            Console.WriteLine(name1[0]); // it will check the first index on variable character // here it will be S
            Console.WriteLine(name1[3]);  // it will print a // it is working with index 

            Console.WriteLine(name1.IndexOf("Suman")); // it will print which index Suman is staring // answer will be 0 index 
            Console.WriteLine(name1.IndexOf("n"));  // it will print 4 which is looking for character n 

            Console.WriteLine(name1.IndexOf("f"));  // we will fer -1 and it means the character is not inside string 

            Console.WriteLine(name1.Substring(6)); // it means the starting index is on 6 index and print chalise

            Console.WriteLine(name1.Substring(6, 3)); // starting at 5 index and printing 3 charcters it will print cha

            Console.ReadLine();
        }
    
    }
}
