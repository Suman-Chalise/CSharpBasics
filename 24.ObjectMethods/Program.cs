using System;

namespace _24.ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student1 = new Students("Suman", "maths", 4.8);
            Students student2 = new Students("Chalise", "Acount", 2.9);

            Console.WriteLine(student1.HasHonors()); // true
            Console.WriteLine(student2.HasHonors()); // false 

            //Console.WriteLine($"Student Name {student1.name}  Subject  {student1.major}"); // can use this to see the result

            Console.ReadLine();
            
        }
    }
}
