namespace _29.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List = data structure that represents a list of objects that can be accessed by index.
            //     similar to array, but can dynatuically increase/decrease size
            // using system.collections.generic 

            //-----------------------------------------ARRAY ----------------------------------------------------

            //string[] food = new string[3];

            //food[0] = "Pizza";
            //food[1] = "Bhat";
            //food[2] = "hot dog";

            //foreach ( string foodItem in food)
            //{
            //    Console.WriteLine(foodItem);     // this will work perfectly.    
            //}

            //----------------------------------------------------ARRAY-----------------------------------------------------------------------

            // if we add one more item in above array it will not work, eg - 

            //string[] food = new string[3];  // we set undex to 3 

            //food[0] = "Pizza";
            //food[1] = "Bhat";
            //food[2] = "hot dog";
            //food[3] = "naan";        // and we added 4 items rather than 3 

            //foreach (string foodItem in food)
            //{
            //    Console.WriteLine(foodItem);    // with 4 we added it will run an exception( error)
            //                                    // Now this case we use List which will be perfect below - 
            //}

            //--------------------LIST---------------------------------------------------------------- LIST -----------------------------------------------------

            //List<string> food = new List<string>();

            //food.Add("pizza");
            //food.Add("Bhat");
            //food.Add("hot dog");

            //foreach (string item in food)
            //{
            //    Console.WriteLine(item);

            //}   // this works fine, lets add more below ---

            //-------------------------------------------------------List--------------------------------List-------------------------------------------

            List<string> food = new List<string>();

            food.Add("pizza");
            food.Add("Bhat");
            food.Add("hot dog");
            food.Add("Naan");   // we can add more

            //food.Remove("pizza");
            //food.Remove(food[0]);
            //food.Insert(0)
            food.Insert(0, "Sushi");
            food.Sort();  // sort by alphabetic
            food.Reverse(); // sort reverse way
            food.Clear(); // remove all list 


            //Console.WriteLine(food.IndexOf("Naan"));
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food[0]); // it will work for index as well 
            // Console.WriteLine(food.LastIndexOf("fries"))
            //Console.WriteLine(food.Contains("Sushi")); // this willl return Boolean ( true / false)

            //------we can convert list in to Array -------------------------------
            //string[] foodArray = food.ToArray();



            foreach (string item in food)
            {
                Console.WriteLine(item);

            }

        }
    }
}