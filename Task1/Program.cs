using System;
using System.Linq;
using Tasks.ChessBoardCore;
using Tasks.Interfaces;

namespace Task1 {
    class Program {
        static void Main(string[] args)
        {
            IParserArguments parserArguments = new ParserArgumentsChessBoard();
            IConsoleMenu consoleMenu = new ChessBoardMenu();
            bool isValid;
            int height, width;
            string command = String.Empty;
            while (true)
            {
                if(args.Length != 0)
                {
                    command = args[0];
                }

                switch (command)
                {
                    case "/create":
                    {
                        isValid = parserArguments.IsValid(args, true);

                        if (isValid)
                        {
                            Int32.TryParse(args[1], out height);
                            Int32.TryParse(args[2], out width);
                            ChessBoard<char> chessBoard = new ChessBoard<char>(width, height, '*');
                            Console.WriteLine(chessBoard);
                        }
                        else
                        {
                            consoleMenu.ShowMenu();
                        }
                        break;
                    }
                    default:
                    {
                        consoleMenu.ShowMenu();
                        break;
                    }
                }
                args = Console.ReadLine().Split(' ');
            }
        }
    }
}
