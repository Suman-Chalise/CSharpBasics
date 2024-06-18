using System;

namespace _20._2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid = {            // here [,] means 2d array
                {1, 2},
                {2,3},
                {5, 6}

            };

            Console.WriteLine(numberGrid[0, 0]);  // it will find teh 0 index and o index  
        }
    }
}
