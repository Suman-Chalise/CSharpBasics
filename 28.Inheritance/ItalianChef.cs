using System;
using System.Collections.Generic;
using System.Text;

namespace _28.Inheritance
{
    class ItalianChef : chef   // we just added  : chef  this is called Inheritence. Italian chef can do all the work which chef can do
    {

        public void makePasta()
        {
            Console.WriteLine("Italian chef can make Pasta");
        }

        public override void MakeSpecialDish()   // now we put override to override the special dish 
        {
            Console.WriteLine("The Chef makes LASANNAEa -- ");
        }
    }
}
