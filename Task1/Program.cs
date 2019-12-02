using System;
using System.Linq;
using Tasks;
using Tasks.ChessBoardCore;
using Tasks.Interfaces;

namespace Task1 {
    class Program {
        static void Main(string[] args)
        {
            ChessBoardApp chessBoardApp = new ChessBoardApp(new ParserArgumentsChessBoard(), new ChessBoardMenu());
            chessBoardApp.Start(args);
        }
    }
}
