using _1_ChessBoard.ChessBoardCore.MenuStrings;
using Common.Interfaces;
using System;

namespace _1_ChessBoard.ChessBoardCore
{
    public class ChessBoardMenu : IConsoleMenu
    {

        public void ShowMenu()
        {
            string menuText = string.Format("{0} {1} {2} {3}",
                ChessBoardMenuText.MENU_CREATE_COMMAND,
                ChessBoardMenuText.MENU_HEIGHT_PARAM,
                ChessBoardMenuText.MENU_WIDTH_PARAM,
                ChessBoardMenuText.MENU_CREATE_DESCRIPTION);

            Console.WriteLine(menuText);
        }
    }
}
