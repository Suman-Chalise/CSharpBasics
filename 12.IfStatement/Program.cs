using System;

namespace _12.IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine("you are male");

            }


            Console.ReadLine();
        }
    }
}


// More codes and information Below
/*
--------------------------------------------------------


        static void Main(string[] args)
        {

            bool isMale = true;  // if we changed to false it will not print below 

            if (isMale)
            {
                Console.WriteLine("you are male");

            } else
            {
                Console.WriteLine("you are not male");
            }


            Console.ReadLine();


        }
   



    }
----------------------------------------------------------------------------------



            bool isMale = true;  // if we changed to false it will not print below 
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("you are a tall male");

            } else
            {
                Console.WriteLine("you are not eith not not tall or male");
            }


            Console.ReadLine();

------------------------------------------------------

we are using && = and operator 

|| or operator 


  if (isMale || isTall)

!isTall = notTall 
! = not 

else if 

else 

---------------------------------------------------------------------------


            bool isMale = true;  // if we changed to false it will not print below 
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("you are a tall male");

            } else if (isMale && !isTall)
            {
                Console.WriteLine("you are a male but not tall ");

            } else if (!isMale && isTall)
            {
                Console.WriteLine(" you are tall but not a male")

            }
            
            else
            {
                Console.WriteLine("you are not eith not not tall or male");
            }


            Console.ReadLine();


        }

-------------------------------------------------------------------------------------------------

More If statement like Comparison etc

-------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {

            Console.WriteLine(GetMax(20, 10));  // specify parameters here 

            Console.ReadLine();

        }

        static int GetMax( int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            } else
            {
                result = num2;
            }

            return result;

        }

-------------------------------------------------------------------------------------

        static void Main(string[] args)
        {

            Console.WriteLine(GetMax(29, 100, 25));

            Console.ReadLine();

        }

        static int GetMax( int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;

            }

            return result;

        }











*/
