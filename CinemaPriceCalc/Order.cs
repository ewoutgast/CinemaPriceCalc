using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaPriceCalc
{
    class Order
    {
        private int orderNr;
        private bool studentOrder;
        private List<MovieTicket> tickets;

        public Order(int orderNr, bool studentOrder)
        {
            this.orderNr = orderNr;
            this.studentOrder = studentOrder;
            this.tickets = new List<MovieTicket>();
        }
        public int getOrderNr()
        {
            return orderNr;
        }
        public void AddSeatReservation(MovieTicket ticket)
        {
            tickets.Add(ticket);
        }
        public double calculatePrice()
        {
            double premiumPrice = studentOrder ? 2 : 3;
            double totalPrice = 0;
            bool second = false;
            foreach(MovieTicket ticket in tickets)
            {
                if(studentOrder || !isWeekend(ticket.getDate()))
                {
                    if (!second)
                    {
                        totalPrice += ticket.getPrice();
                        if (ticket.isPremiumTicket())
                        {
                            totalPrice += premiumPrice;
                        }
                        second = true;
                    }
                    else
                    {
                        second = false;
                    }
                }
                else
                {
                    if(tickets.Count > 5)
                    {
                        totalPrice += (ticket.getPrice() + (ticket.isPremiumTicket() ? premiumPrice : 0)) * 0.90;
                    }
                    else
                    {
                        totalPrice += (ticket.getPrice() + (ticket.isPremiumTicket() ? premiumPrice : 0));
                    }
                    
                }
            }
            return totalPrice;
        }

        private bool isWeekend(DateTime date)
        {
            if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            return false;
        }

    }
}
