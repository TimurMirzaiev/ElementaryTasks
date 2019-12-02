using System;
using System.Collections.Generic;
using System.Text;
using Tasks.Interfaces;

namespace Tasks.ChessBoardCore {
    class ChessBoardMenu: IConsoleMenu {

        public void ShowMenu()
        {
            Console.WriteLine("/create height width - create a board by entering the height and width of the board");
        }
    }
}
