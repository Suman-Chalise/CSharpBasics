using System;

namespace _8.MadLibsGames
{
    class Program
    {
        static void Main(string[] args)
        {

            string color, pluralNoun, celebrity;

            Console.Write("enter a colour ");
            color = Console.ReadLine();

            Console.Write("enter a plural Noun ");
            pluralNoun = Console.ReadLine();

            Console.Write("enter a celebrity ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue ");
            Console.WriteLine("I love " + celebrity);
        }
    }
}
