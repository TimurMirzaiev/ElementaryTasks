using _6_HappyTickets.HappyTicketsCore.Strategy;
using _6_HappyTickets.LuckyTicketsCore.Model;
using _6_LuckyTickets.LuckyTicketsCore;
using _6_LuckyTickets.LuckyTicketsCore.Menu;
using _6_LuckyTickets.LuckyTicketsCore.Menu.MenuStrings;
using Common.Interfaces;
using System;
using System.Linq;
using System.Text;

namespace _6_HappyTickets.HappyTicketsCore
{
    public class LuckyTicketsApp
    {
        private readonly IParserArguments _parserArguments = new LuckyTicketsParserArguments();
        private readonly IConsoleMenu _consoleMenu = new LuckyTicketsMenu();

        public void Run(string[] args)
        {
            for (; ; )
            {
                string command = string.Empty;
                bool isValid = false;

                if (args.Length != 0)
                {
                    command = args[0].ToLower();
                }

                switch (command)
                {
                    case LuckyTicketsMenuText.MENU_IS_LUCKY_COMMAND:
                    {
                        isValid = _parserArguments.IsValid(args, true);

                        if (isValid)
                        {
                            string symbols = args[1];

                            Ticket ticket = new Ticket(symbols);
                            TicketDrawer ticketDrawer = new TicketDrawer();
                            ticketDrawer.Draw(ticket);
                            bool isLucky = ticket.IsLuckyTicket(new MoscowStrategy());
                            Console.WriteLine(isLucky);    //todo LuckyDrawer?
                        }
                        else
                        {
                            _consoleMenu.ShowMenu();
                        }
                        break;
                    }
                    default:
                    {
                        _consoleMenu.ShowMenu();
                        break;
                    }
                }
                args = Console.ReadLine().Split(' ');
            }
        }
    }
}
