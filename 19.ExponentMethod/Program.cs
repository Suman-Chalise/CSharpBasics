using System;

namespace _19.ExponentMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //example for this is 2, 3 means it will have 2^3 
            Console.WriteLine(GetPow(2, 3));
        }
        static int GetPow(int baseNum, int PowNum)
        {
            int result = 1;
            for (int i = 0; i < PowNum; i++)
            {
                result = result * baseNum;
            }


            return result;


        }


    }
}
