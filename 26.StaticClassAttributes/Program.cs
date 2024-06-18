using System;

namespace _26.StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            song holiday = new song("Holuday", "Green Day", 200);
            Console.WriteLine(song.songCount);  // we will get 1 here 
            song kashmir = new song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(song.songCount);  // we will get 2 here 


            Console.WriteLine(holiday.title);
            Console.WriteLine(kashmir.title);

            Console.WriteLine(holiday.artist);
            Console.WriteLine(kashmir.artist);

            Console.WriteLine(song.songCount); // calling that static count // songCount is static attributes belongs to class song 

            Console.ReadLine();
        }
    }
}

/*
 If can only use song.songCount attributes not holiday.songCount!

if we want to access with individual we will need to create another method on class song 

within song class we ad below - 

public getsongCount(){

return songCount;
}


and then adding this to program.cs


Concole.writeline(kashmir.getSongCount());
 
 
 
 */
