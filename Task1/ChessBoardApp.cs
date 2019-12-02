using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ChessBoardCore;
using Tasks.Interfaces;

namespace Tasks {
    class ChessBoardApp {
        IParserArguments _parserArguments;
        IConsoleMenu _consoleMenu;

        public ChessBoardApp(IParserArguments parserArguments, IConsoleMenu consoleMenu)
        {
            _parserArguments = parserArguments;
            _consoleMenu = consoleMenu;
        }
        public void Start(string[] args)
        {
            while (true)
            {
                string command = String.Empty;
                bool isValid;

                if (args.Length != 0)
                {
                    command = args[0];
                }

                switch (command)
                {
                    case "/create":
                    {
                        isValid = _parserArguments.IsValid(args, true);

                        if (isValid)
                        {
                            Int32.TryParse(args[1], out int height);
                            Int32.TryParse(args[2], out int width);
                            ChessBoard<char> chessBoard = new ChessBoard<char>(width, height, '*');
                            Console.WriteLine(chessBoard);
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
