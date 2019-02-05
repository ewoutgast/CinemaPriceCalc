using System;

namespace CinemaPriceCalc
{
    class MovieScreening
    {
        private Movie movie;
        private DateTime datetime;
        private double pricePerSeat;

        public MovieScreening(Movie movie, DateTime datetime, double pricePerSeat)
        {
            this.movie = movie;
            movie.addScreening(this);
            this.datetime = datetime;
            this.pricePerSeat = pricePerSeat;
        }
        public double getPricePerSeat()
        {
            return this.pricePerSeat;
        }
        public DateTime getDate()
        {
            return this.datetime;
        }
        public override string ToString()
        {
            return this.movie.getTitle() + " - " + this.datetime;
        }
    }
}