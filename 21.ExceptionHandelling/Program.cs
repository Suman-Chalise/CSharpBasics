using System;

namespace _21.ExceptionHandelling
{
    class Program
    {
        static void Main(string[] args)
        {
            // below is a simple divide calculator 
           /* {

                Console.Write("ENter a number ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Another Number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);


            }

            */
           // the above is a program for divide calculator. for it to use expception handelling we use below - 


            try
            {
                Console.Write("ENter a number ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Another Number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            catch
            {
                Console.WriteLine("Error");
            }

        }
    }
}

/*
3........................................................................



        static void Main(string[] args)    

        {
            try
            {
                Console.Write("ENter a number ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Another Number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            catch ( Exception e)
            {
                Console.WriteLine(e.Message);
            }

           
 

        }


...... So what happned in on 1st main program, if we try to enter character or divide something like 0 the program could't handle and it crashes. 

to fix the crasing issue we use try catch function. 

We will copy all code within try and write message on catch. It will hlep appliction not to crash if user input invalid dgits or any unusual input

-------------------------------------------------------------------------------------------------------------------------


// we can specify teh error message like below 


        static void Main(string[] args)    

        {
            try
            {
                Console.Write("ENter a number ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Another Number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            catch (DivideByZeroException e)   // if user attemp to divide by zero it will run bllow
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)    // is user attemp character on input below will appear 
            {
                Console.WriteLine(e.Message);
            }

           
 

        }

------------------------------------------------------------------------------------------------------------------

        static void Main(string[] args)    

        {
            try
            {
                Console.Write("ENter a number ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Another Number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("error");  // even though programs runs this will execute 
                // however we do not use this, this is just optional 
            }

           
 

        }
 
 
 
 
 
 
 
 
 */
