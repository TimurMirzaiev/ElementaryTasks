using Tasks;
using Tasks.ChessBoardCore;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoardApp chessBoardApp = new ChessBoardApp(new ParserArgumentsChessBoard(), new ChessBoardMenu());
            chessBoardApp.Run(args);
        }
    }
}
