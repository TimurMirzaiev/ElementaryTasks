using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasks.Interfaces;

namespace Tasks.ChessBoardCore {
    class ParserArgumentsChessBoard : IParserArguments {
        public bool IsValid(string[] args, bool skipFirstArgument)
        {
            if (skipFirstArgument)
            {
                args = args.Skip(1).ToArray();
            }
            if(args.Length == 2)
            {
                return true;
            }
            return false;
        }
    }
}
