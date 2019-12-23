using _1_ChessBoard.ChessBoardCore;
using _1_ChessBoard.ChessBoardCore.MenuStrings;
using Common.Interfaces;
using Serilog;
using System;

namespace _1_ChessBoard
{
    public class ChessBoardApp
    {

        private readonly IParserArguments _parserArguments;
        private readonly IConsoleMenu _consoleMenu;

        public ChessBoardApp(IParserArguments parserArguments, IConsoleMenu consoleMenu)
        {
            _parserArguments = parserArguments;
            _consoleMenu = consoleMenu;
        }

        public void Run(string[] args)
        {
            bool isExit = false;

            while( isExit == false)
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
                            Int32.TryParse(args[1], out int height);
                            Int32.TryParse(args[2], out int width);

                            try
                            {
                                ChessBoard chessBoard = ChessBoard.CreateChessBoard(height, width);
                                ChessBoardDrawer chessBoardDrawer = new ChessBoardDrawer();
                                chessBoardDrawer.Draw(chessBoard);
                            }
                            catch(ArgumentException ex)
                            {
                                Log.Logger.Error("ArgumentException: {0}", ex.Message);
                                _consoleMenu.ShowMenu();
                            }
                        }
                        else
                        {
                            Log.Logger.Error("Invalid arguments for command {0}", 
                                ChessBoardMenuText.MENU_CREATE_COMMAND);
                            _consoleMenu.ShowMenu();
                        }
                        break;
                    }
                    case ChessBoardMenuText.MENU_EXIT_COMMAND:
                    {
                        Log.Logger.Information("{0} is executed", ChessBoardMenuText.MENU_EXIT_COMMAND);
                        isExit = true;
                        break;
                    }
                    default:
                    {
                        Log.Logger.Error("Invalid command");
                        _consoleMenu.ShowMenu();
                        break;
                    }
                }

                args = Console.ReadLine().Split(' ');
            }
        }
    }
}
