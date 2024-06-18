using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections;

namespace _30.Lamda
{
    internal class Program
    {
        static Random _random = new Random();
        static void Main(string[] args)
        {
            //var myNumbers = new List<int> {0, 1, 2, 3, 4, 5, 8, 22, 34, 99 };

            //var numbersOver5 = new List<int>();

            //foreach (var number in myNumbers)
            //{
            //    if (number > 5)
            //    {
            //        numbersOver5.Add(number);
            //        //numbersOver5.Add((int)number);
            //    }

            //}         

            //foreach ( var item in numbersOver5)
            //{
            //    Console.WriteLine(item);
            //}

            // above we use traditionaly but for lamda below - 



            // we use lamda for above. ------------------------------------------------------



            //var numbersOver5 = myNumbers.Where(n => n > 5); // or can use (number => number > 5);

            //foreach (var item in numbersOver5) 
            //{
            //    Console.WriteLine(item);
            // }

            //---------------------------------------------------------------------------------------------------



            //var gameList = new List<Game>
            //{
            //    new Game {Name = "Mario", ReleaseDate = new DateTime(1999,10,2), SteamScore = 9},
            //    new Game {Name = "Dave", ReleaseDate = new DateTime(2000, 1, 3), SteamScore = 8},
            //    new Game {Name = "Fifa", ReleaseDate =new DateTime(2020, 2, 10), SteamScore = 12},

            //    new Game {Name = "Suman", ReleaseDate =new DateTime(2021, 2, 10), SteamScore = 11},
            //    new Game {Name = "Chalise", ReleaseDate =new DateTime(2022, 2, 10), SteamScore = 10},
            //    new Game {Name = "tututua", ReleaseDate =new DateTime(2023, 2, 10), SteamScore = 14},

            //};

            ////bool allhave9scoreorBetter = gameList.All(g => g.SteamScore >= 9);

            //// IEnumerable<string> gameNames = gameList.Select(g => g.Name);
            ////List<string> gameNames = gameList.Select(g => g.Name).ToList();

            ////var suggestedgames = gameList.Where(g=>g.SteamScore == 9).ToList();

            //var suggestedgames = gameList.Where(g => g.SteamScore >= 9 && g.ReleaseDate.Year > 2018).OrderBy(g => _random.Next()).Take(3);
            //foreach (var game in suggestedgames)
            //{
            //    Console.WriteLine($"{game.Name} {game.SteamScore} {game.ReleaseDate}");
            //}

            // ------------------------------------------------------------------------- TEST for myself --------------------------------------------------

            //var mylist = new List<int> { 2, 4, 5, 6, 7, 8, 9, 23, 45, 6, 78, 100, 200, 300, 345, 0, 39, 3, 45, 6 };

            //var numberOver10 = mylist.Where(m => m < 10);



            //foreach (var number in numberOver10)
            //{

            //    Console.WriteLine(number);

            //}


            //----------------------------------------

            int[] numbers =  {0, 1, 2, 3, 4, 5, 8, 22, 34, 99 };
            IEnumerable<int> even_numbers = from number in numbers
                                            where number % 2 == 0 //Even number
                                            orderby number // we can use order by try removing this and try
                                            select number;
            foreach (int number in even_numbers)
            {
                Console.WriteLine(number); // it will print even number list, 
            }


        }
    }
}