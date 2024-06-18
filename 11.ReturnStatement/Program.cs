using System;

namespace _11.ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            cube(5);  // it will not work 
            Console.WriteLine(cube(5));  // this will work because return statement will pass information to cube();
        }
        static int cube(int num)           // here we are not using void instead we are using int and cube as method // eg 2^3 = 2x2x2
        {

            int result = num * num * num;
            return result;


        }

    }
}


// another example below - 
/*
static void Main(string[] args)
{


    // another example 

    int cubedNumber = cube(5);
    Console.WriteLine(cubedNumber); // this will also works 


}
static int cube(int num)           // here we are not using void instead we are using int and cube as method // eg 2^3 = 2x2x2
                                   // we can change static double cube( int num ) too so all options
{

    int result = num * num * num;
    return result;


}
*/
