using _1_ChessBoard;
using _1_ChessBoard.ChessBoardCore;
using Common.Interfaces;
using Serilog;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1_ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterLogger();

            ChessBoardApp chessBoardApp = new ChessBoardApp(new ParserArgumentsChessBoard(), new ChessBoardMenu());
            chessBoardApp.Run(args);
        }

        private static void RegisterLogger()
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
                .WriteTo.File("log.txt")
                .CreateLogger();
        }
    }
}
