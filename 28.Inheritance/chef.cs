using System;
using System.Collections.Generic;
using System.Text;

namespace _28.Inheritance
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
        /* public void MakeSpecialDish()
         {
             Console.WriteLine("The Chef makes BBQ ribs ");
         }
        */
        public virtual void MakeSpecialDish()   // we are chaning this because different chef can make their own special dish /  we added virtual so that we can overide in sub classes 
        {
            Console.WriteLine("The Chef makes BBQ ribs ");
        }

    }
}
