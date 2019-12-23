using Common.Interfaces;
using System.Linq;

namespace _1_ChessBoard.ChessBoardCore
{
    public class ParserArgumentsChessBoard : IParserArguments
    {
        public bool IsValid(string[] args, bool skipFirstArgument = false)
        {
            bool result = false;

            if (skipFirstArgument)
            {
                args = args.Skip(1).ToArray();
            }

            if (args.Length == 2)
            {
                result = int.TryParse(args[0], out int width)
                     && int.TryParse(args[1], out int height);
            }

            return result;
        }
    }
}
