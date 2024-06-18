using System;
using System.Collections.Generic;
using System.Text;

namespace _25.GettersAndSetters
{
    class movies
    {

        public string movie;
        public string director;
        private string rating;  // changing it to private so that only can access within this class movies

        public movies(string aMovie, string aDirector, string aRating)
        {
            movie = aMovie;
            director = aDirector;
            Rating = aRating;

        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }

            }
        }
    }
}
