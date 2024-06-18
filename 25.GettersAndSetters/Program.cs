using System;

namespace _25.GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            movies movie1 = new movies("Thor", "Hamsworth", "PG");
            movies movie2 = new movies("Sapana", "Suman", "PG-13");

            // G, PG, PG-13, R, NR  // we will have these in the Rating 
            Console.WriteLine(movie1.Rating);  // it can easily access rating because we have made rating public 

            movie2.Rating = "Cat";
            Console.WriteLine(movie2.Rating);  // we will get NR because it is not valid, 

            movie2.Rating = "R";
            Console.WriteLine(movie2.Rating); // it will accept R and display
        }
    }
}
