using System;

namespace _28.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            chef nameChef = new chef();
            nameChef.MakeChicken();    // normal chef can make chicken 
            nameChef.MakeSalad();
            nameChef.MakeSpecialDish(); // special dish bbq ribs

            // below for italian chef 
            ItalianChef ItalianCook = new ItalianChef();
            ItalianCook.MakeChicken();     // now this will work because of inheritence in class 
            ItalianCook.MakeSalad();
            ItalianCook.MakeSpecialDish();

            ItalianCook.makePasta(); // this one I added in italianchef class and only italianChef can make this pasta 

            ItalianCook.MakeSpecialDish(); // now italian chef can make special their own dish 
        }
    }
}


/*
 * 
We are using three classes here ->

oone chef class which we can call super class 

another one it ItalianChef class ( Italian chef can make all in class chef) 
italian class called sub class 

--- 

on another project Italian chef should make his own dish for special dish rather than same special dish for all chef 


first one ----------------------------------------------~~~#######################################-----------------------------------------

chef.cs 
----------

namespace Giraffe
{
    class chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef can make chicken ");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef can Make Salad ");
        }
        public void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ ribs ");
        }
    }
}

ItalianChef.cs 
-----------------

namespace Giraffe
{
    class ItalianChef : chef   // we just added  : chef  this is called Inheritence. Italian chef can do all the work which chef can do
    {
    
    }
}


program.cs
----------------------

    class Program
    {
        static void Main(string[] args)    

        {
            chef nameChef = new chef();
            nameChef.MakeChicken();    // normal chef can make chicken 
            nameChef.MakeSalad();
            nameChef.MakeSpecialDish(); // special dish bbq ribs

            // below for italian chef 
            ItalianChef ItalianCook = new ItalianChef();
            ItalianCook.MakeChicken();     // now this will work because of inheritence in class 
            ItalianCook.MakeSalad();
            ItalianCook.MakeSpecialDish();


        }



    }

------------------------------------------------------------------------------------------ Second one is already there with updated --------------------------
 
 
 
 
 
 */
