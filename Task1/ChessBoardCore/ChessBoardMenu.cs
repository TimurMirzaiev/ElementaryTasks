using System;
using Tasks.ChessBoardCore.EnumsString;
using Tasks.Interfaces;

namespace Tasks.ChessBoardCore
{
    class ChessBoardMenu : IConsoleMenu
    {

        public void ShowMenu()
        {
            string menuText = String.Format("{0} {1} {2} {3}",
                ChessBoardMenuText.MENU_CREATE_COMMAND,
                ChessBoardMenuText.MENU_HEIGHT_PARAM,
                ChessBoardMenuText.MENU_WIDTH_PARAM,
                ChessBoardMenuText.MENU_CREATE_DESCRIPTION);

            Console.WriteLine(menuText);
        }
    }
}
