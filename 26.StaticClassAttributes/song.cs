using System;
using System.Collections.Generic;
using System.Text;

namespace _26.StaticClassAttributes
{
    class song
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;  // adding this for static 

        public song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
    }
}
