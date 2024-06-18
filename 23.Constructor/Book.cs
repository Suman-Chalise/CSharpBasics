using System;
using System.Collections.Generic;
using System.Text;

namespace _23.Constructor
{
    class Book
    {

        public string title;
        public string author;
        public int pages;

        //public Book()  // we will call this as constructors because it will be called upon
        //{
        //    Console.WriteLine("creating Book ");

        //}

        // We can create many constructor as we like. Lets say create one constructor which do not take any parameter 
        // and lets create another contructor which will takes the three parameters which is above, 


        // --- below will takes three parameters ----- // // if you want to create many book then the below will be good, because it uses less codes ----//
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            
        }

        // -- below will takes no parameters ---- ///

        public Book() 
        { 
        
        }

    }
}
