using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaPriceCalc
{
    class MovieTicket
    {
        private MovieScreening movieScreening;
        private bool pemiumTicket;
        private int seatRow;
        private int seatNr;
        public MovieTicket(MovieScreening movieScreening, bool pemiumTicket, int seatRow, int seatNr)
        {
            this.movieScreening = movieScreening;
            this.pemiumTicket = pemiumTicket;
            this.seatRow = seatRow;
            this.seatNr = seatNr;
        }
        public bool isPremiumTicket()
        {
            return this.pemiumTicket;
        }
        public double getPrice()
        {
            return this.movieScreening.getPricePerSeat();
        }
        public DateTime getDate()
        {
            return this.movieScreening.getDate();
        }

        public override string ToString()
        {
            return movieScreening.ToString() + " - row " + seatRow + ", seat " + seatNr + (this.pemiumTicket ? "(Premium)" : "");
        }
    }
}
