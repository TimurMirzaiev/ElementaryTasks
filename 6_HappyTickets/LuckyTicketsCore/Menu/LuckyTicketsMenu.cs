using _6_LuckyTickets.LuckyTicketsCore.Menu.MenuStrings;
using Common.Interfaces;
using System;
using System.Text;

namespace _6_LuckyTickets.LuckyTicketsCore.Menu
{
    public class LuckyTicketsMenu : IConsoleMenu
    {
        public void ShowMenu()
        {
            string menuText = string.Format("{0} {1} {2}",
                   LuckyTicketsMenuText.MENU_IS_LUCKY_COMMAND,
                   LuckyTicketsMenuText.MENU_IS_LUCKY_PARAM,
                   LuckyTicketsMenuText.MENU_IS_LUCKY_DESCRIPTION);

            Console.WriteLine(menuText);
        }
    }
}
