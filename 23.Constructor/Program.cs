using System;

namespace _23.Constructor
{
    class Program
    {
        static void Main(string[] args)
        {


            // -- eample for book class constructor where it takes 3 parameters -- //

            Book oneBook = new Book("Ramayan", "Valmiki", 1000);
            Book anoBoo = new Book("mahabharat", "Krishna", 20000);

            // exmaple for book class constructor where it doesn't take any parameters -- //

            Book book1 = new Book();
            book1.title = "Horry potta";
            book1.author = "JK rowling";
            book1.pages = 23;

            Book anothe = new Book();
            anothe.title = "No limit in the sky";
            anothe.author = "No one";
            anothe.pages = 24;

            // -- now when we compare above, the one contructor which is taking three parameters is only 2 lines of code 
            // where the consctuctor which is taking no parameters is taking 8 lines of codes. 

            // therefore constructor with parameters will be very useful 

            Console.WriteLine(oneBook.title);
            Console.WriteLine(anoBoo.title);
            Console.WriteLine(book1.title);
            Console.WriteLine(anothe.title);


            //Book book1 = new Book();   // objext book1 created 
            //book1.title = "harry potter";
            //book1.author = "Jk rowling";
            //book1.pages = 400;


            ////Console.WriteLine(book1.title);
            ////Console.WriteLine(book1.author);
            ////Console.WriteLine(book1.pages);

            //Book book2 = new Book();   // objext book2 created 
            //book2.title = "Lords of ring";
            //book2.author = "Tollkein";
            //book2.pages = 700;

            //Book book3 = new Book();

            //// Console.WriteLine(book2.title);

            //Console.ReadLine();
        }
    }
}

/*
 //few Example bleow 

 program.cs

        static void Main(string[] args)    

        {
            Book book1 = new Book("suman");   // objext book1 created 
            book1.title = "harry potter";
            book1.author = "Jk rowling";
            book1.pages = 400;


            //Console.WriteLine(book1.title);
            //Console.WriteLine(book1.author);
            //Console.WriteLine(book1.pages);

            Book book2 = new Book("test");   // objext book1 created 
            book2.title = "Lords of ring";
            book2.author = "Tollkein";
            book2.pages = 700;

            Book book3 = new Book("third");

           // Console.WriteLine(book2.title);

            Console.ReadLine();


        }

Book.cs


    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string name)  // we will call this as constructors because it will be called upon
        {
            Console.WriteLine(name);  // this is accepting one parameter here 

        }

    }


-----------------------------------------------------------------------

program.cs 

        static void Main(string[] args)    

        {
            Book book1 = new Book("harry potter", "JK rowling", 400);   // passing this information rather than one by one below - 
            //book1.title = "harry potter";
           // book1.author = "Jk rowling";
            //book1.pages = 400;

            Book book2 = new Book("Lords of ring", "Tollkein", 700);
            //book2.title = "Lords of ring";
            //book2.author = "Tollkein";
            //book2.pages = 700;

            Console.WriteLine(book2.title);  // prints lord of teh rings

            book2.title = "The Hobbit";  // changing the value on boo2 title 

            Console.WriteLine(book2.title);  // produce updated result 



            Console.ReadLine();


        }

Book.cs

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)  //
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
           

        }

    }
}

------------------------------------------------------------------------


program .cs

        static void Main(string[] args)    

        {
            Book book1 = new Book("harry potter", "JK rowling", 400);   // passing this information rather than one by one below - 
            //book1.title = "harry potter";
           // book1.author = "Jk rowling";
            //book1.pages = 400;

            Book book2 = new Book("Lords of ring", "Tollkein", 700);
            //book2.title = "Lords of ring";
            //book2.author = "Tollkein";
            //book2.pages = 700;

        

            Console.WriteLine(book2.title);  // prints lord of teh rings

            book2.title = "The Hobbit";  // changing the value on boo2 title 

            Console.WriteLine(book2.title);  // produce updated result 

            Book book3 = new Book(); // we are now creating book without any parameter as well 


            Console.ReadLine();


        }

Book.cs 

namespace Giraffe
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)  // creating constructors 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
           

        }

        public Book()  // we can create another constructors as well which do not take any parameters 
        {


        }

    }
}

 
 
 
 
 */
