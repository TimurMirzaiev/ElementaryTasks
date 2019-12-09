using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Envelopes
{
    class EnvelopesApp
    {
        private readonly IParserArguments _parserArguments;
        private readonly IConsoleMenu _consoleMenu;

        public EnvelopesApp(IParserArguments parserArguments, IConsoleMenu consoleMenu)
        {
            _parserArguments = parserArguments;
            _consoleMenu = consoleMenu;
        }

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
                    case ChessBoardMenuText.MENU_CREATE_COMMAND:
                    {
                        isValid = _parserArguments.IsValid(args, true);

                        if (isValid)
                        {
                            int.TryParse(args[1], out int height);
                            int.TryParse(args[2], out int width);
                            ChessBoard chessBoard = new ChessBoard(width, height);
                            ChessBoardDrawer chessBoardDrawer = new ChessBoardDrawer();
                            chessBoardDrawer.Draw(chessBoard);
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
