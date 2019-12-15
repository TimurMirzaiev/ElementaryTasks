using _6_LuckyTickets.LuckyTicketsCore.Interfaces;
using _6_LuckyTickets.LuckyTicketsCore.Model;
using _6_LuckyTickets.LuckyTicketsCore.Validation;
using System;
using FluentValidation.Results;

namespace _6_LuckyTickets.LuckyTicketsCore.LuckyTicketStrategy
{
    class PiterStrategy : ILuckyTicketStrategy
    {
        public bool IsLuckyTicket(Ticket ticket)
        {
            bool res = false;
            bool isValid = Validate(ticket);

            if (isValid)
            {
                int sumOfEven = 0;
                int sumOfOdd = 0;

                for (int i = 0; i < ticket.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumOfEven += ticket[i];
                    }
                    else
                    {
                        sumOfOdd += ticket[i];
                    }
                }
                res = sumOfEven == sumOfOdd;
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
