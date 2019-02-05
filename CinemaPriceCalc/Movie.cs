using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaPriceCalc
{
    class Movie
    {
        private string title;
        private List<MovieScreening> screenings;
        public Movie(string title)
        {
            this.title = title;
            screenings = new List<MovieScreening>();
        }
        public string getTitle()
        {
            return this.title;
        }
        public void addScreening(MovieScreening screening)
        {
            this.screenings.Add(screening);
        }
    }
}
