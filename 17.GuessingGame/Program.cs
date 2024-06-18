using System;

namespace _17.GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess = "Suman";
            string GuessWord = "";
            int count = 0;
            int maxcount = 4;
            bool outofmove = false;


            while (GuessWord != guess && !outofmove)
            {
               if (count < maxcount)
                {
                    Console.Write("Please enter a guess\n");
                    GuessWord = Console.ReadLine();
                    count++;

                } else 
                {
                    outofmove = true;
                }
            }
            if (outofmove)
            {
                Console.WriteLine("You are out of move! therefore Lost ");
            } else
            {
                Console.WriteLine("thats correct "+ GuessWord);
            }
         
            //Console.WriteLine("thats correct "+ GuessWord);


















            //string secredWord = "Suman";
            //string guess = "";


            //while (guess != secredWord)
            //{
            //    Console.Write("Enter Guess: ");
            //    guess = Console.ReadLine();

            //}
            //Console.WriteLine("you WIn");
        }
    }
}

/*
-----------------------------------------------------


using DO While for game 

------------------------------------------

            string secretWord = "Suman";
            string guess = "";

            do
            {
                Console.Write("please Enter a guess: ");
                guess = Console.ReadLine();

            } while (secretWord != guess);

                Console.WriteLine("thats corerct ");

        }

---------------------------------------------------

continue Guessting Game 

-----------------------------------------

        static void Main(string[] args)
        {
            string secretWord = "Suman";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 4;
            bool outOfGuesses = false;

            while (secretWord != guess && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("please Enter a guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }


            } 

            if (outOfGuesses)
            {
                Console.Write("out of moves ");

            } else
            {
                Console.Write(" you win!!!!!!!!!!!!");
            }

                

        }




*/
