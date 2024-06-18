namespace _2.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";                            // creating a string // string will be in double quotes ""
            int characterAge;
            characterAge = 35;                                        // creating a integer which is a number and it is another method 

            Console.WriteLine("there was a man named " + characterName);   // + is concenated 
            Console.WriteLine("his age is " + characterAge + " years old ");

            characterName = "Mike";                                   // we can modify variable on middle of program and it will takes effect on below 


            Console.WriteLine(" he like his name " + characterName);
            Console.WriteLine(" he do not want to be " + characterAge);

            // Note We have to specify string, int, float, double before assigning variables 






            Console.ReadLine();
        }
    }
}
