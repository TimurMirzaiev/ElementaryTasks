using _6_HappyTickets.HappyTicketsCore.Model;
using _6_HappyTickets.LuckyTicketsCore.Interfaces;
using System;
using System.Text;

namespace _6_HappyTickets.LuckyTicketsCore.Model
{
    public class Ticket
    {

        private readonly Symbol<char>[] _symbols;

        public Ticket(string symbols)
        {
            _symbols = new Symbol<char>[symbols.Length];

            for (int i = 0; i < symbols.Length; i++)
            {
                _symbols[i] = new Symbol<char>(symbols[i]);
            }
        }

        public bool IsLuckyTicket(ILuckyTicketStrategy luckyTicketStrategy)
        {
            return luckyTicketStrategy.IsLuckyTicket(_symbols);
        }

        public void ShowTicket()
        {
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < _symbols.Length; i++)
            {
                res.Append(string.Format(" {0}", _symbols[i].Data));
            }

            Console.WriteLine(res.ToString());
        }
    }
}
