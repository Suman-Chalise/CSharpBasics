using System;

namespace _22.ClassesAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book();   // objext book1 created 
            book1.title = "harry potter";
            book1.author = "Jk rowling";
            book1.pages = 400;


            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);


            book book2 = new book();   // objext book2 created 
            book2.title = "Lords of ring";
            book2.author = "Tollkein";
            book2.pages = 700;

            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}

//Class is just a specification of data type

//example - class for phone, water bottle, etc

//Object = actual objects on main program

//Note - for aboove we have to create Class called book