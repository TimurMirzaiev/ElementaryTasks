using _6_LuckyTickets.LuckyTicketsCore.Exceptions;
using _6_LuckyTickets.LuckyTicketsCore.Interfaces;
using _6_LuckyTickets.LuckyTicketsCore.Model;
using System;

namespace _6_LuckyTickets.LuckyTicketsCore.LuckyTicketStrategy
{
    public class DeterminatorLuckyTicket
    {

        public bool IsLuckyTicket(Ticket ticket, ILuckyTicketStrategy strategy)
        {
            try
            {
                return strategy.IsLuckyTicket(ticket);
            }
            catch (InvalidLuckyTicketStrategy ex)
            {
                throw new InvalidLuckyTicketStrategy("Invalid lucky ticket strategy", ex);
            }
        }

        /// <summary>
        /// Returns count of the lucky tickets with the specified alghoritm to find lucky ticket
        /// </summary>
        /// <param name="rank">The count of digits in the ticket</param>
        /// <param name="strategy">Alghoritm to find lucky tickets</param>
        /// <returns>Count of the lucky tickets</returns>
        public int CalculateLuckyTickets(int rank, ILuckyTicketStrategy strategy)
        {
            int count = 0;
            int min;
            int max = (int)Math.Pow(10, rank) - 1;

            try
            {
                for (min = 1; min <= max; min++)
                {
                    if (strategy.IsLuckyTicket(Ticket.CreateTicket(rank, min)))
                    {
                        count++;
                    }
                }
            }
            catch (InvalidLuckyTicketStrategy ex)
            {
                throw new InvalidLuckyTicketStrategy("Invalid lucky ticket strategy", ex);
            }

            return count;
        }
    }
}
