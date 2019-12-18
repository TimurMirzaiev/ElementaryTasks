using _6_LuckyTickets.LuckyTicketsCore.Interfaces;
using _6_LuckyTickets.LuckyTicketsCore.Model;
using _6_LuckyTickets.LuckyTicketsCore.Validation;
using System;
using FluentValidation.Results;
using _6_LuckyTickets.LuckyTicketsCore.Exceptions;

namespace _6_LuckyTickets.LuckyTicketsCore.LuckyTicketStrategy
{
    public class MoscowStrategy : ILuckyTicketStrategy
    {

        public bool IsLuckyTicket(Ticket ticket)
        {
            bool res = false;
            bool isValid = Validate(ticket); // length must be even and more than 6 elements

            if (isValid)
            {
                int sumOfFirstHalf = 0;
                int sumOfSecondHalf = 0;

                for (int i = 0; i < ticket.Length / 2; i++)
                {
                    sumOfFirstHalf += ticket[i];
                }

                for (int i = ticket.Length / 2; i < ticket.Length; i++)
                {
                    sumOfSecondHalf += ticket[i];
                }

                res = sumOfFirstHalf == sumOfSecondHalf;
            }
            else
            {
                throw new InvalidLuckyTicketStrategy();
            }

            return res;
        }

        private bool Validate(Ticket ticket)
        {
            return ticket.Length % 2 == 0
                && ticket.Length >= 6;
        }
    }
}
