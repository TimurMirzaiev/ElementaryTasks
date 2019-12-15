using _6_LuckyTickets.LuckyTicketsCore.ConsoleUI;
using _6_LuckyTickets.LuckyTicketsCore.ConsoleUI.MenuStrings;
using _6_LuckyTickets.LuckyTicketsCore.Exceptions;
using _6_LuckyTickets.LuckyTicketsCore.LuckyTicketStrategy;
using _6_LuckyTickets.LuckyTicketsCore.Model;
using Common.Interfaces;
using System;

namespace _6_LuckyTickets.LuckyTicketsCore
{
    public class LuckyTicketsApp
    {
        public void Run(string[] args)
        {
            bool isExit = false;

            while (isExit == false)
            {
                LuckyTicketsUI luckyTicketsUI = new LuckyTicketsUI();
                string command = string.Empty;

                if (args.Length != 0)
                {
                    command = args[0].ToLower();
                }

                switch (command)
                {
                    case LuckyTicketsMenuText.MENU_LUCKY_COMMAND:
                    {
                        Alghorithm alghoritm = luckyTicketsUI.ReadAlghoritmByPath();
                        DeterminatorLuckyTicket determinator = new DeterminatorLuckyTicket();

                        try
                        {
                            switch (alghoritm)
                            {
                                case Alghorithm.Moscow:
                                {
                                    int countMoscow = determinator.CalculateLuckyTickets(6, new MoscowStrategy());
                                    luckyTicketsUI.Show(String.Format("{0} = {1}", LuckyTicketsMenuText.MOSCOW_ALGHORITHM_COUNT_TEXT, countMoscow));
                                    break;
                                }
                                case Alghorithm.Piter:
                                {
                                    int countPiter = determinator.CalculateLuckyTickets(6, new PiterStrategy());
                                    luckyTicketsUI.Show(String.Format("{0} = {1}", LuckyTicketsMenuText.PITER_ALGHORITHM_COUNT_TEXT, countPiter));
                                    break;
                                }
                                case Alghorithm.None:
                                {
                                    break;
                                }
                            }
                        }
                        catch (InvalidLuckyTicketStrategy ex)
                        {
                            throw new InvalidLuckyTicketStrategy("Invalid lucky ticket strategy", ex);
                            //log
                        }
                        luckyTicketsUI.ShowMenu();
                        break;
                    }
                    case LuckyTicketsMenuText.MENU_EXIT_COMMAND:
                    {
                        isExit = true;
                        break;
                    }
                    default:
                    {
                        luckyTicketsUI.ShowMenu();
                        break;
                    }
                }

                args = luckyTicketsUI.ReadArgs();
            }
        }
    }
}
