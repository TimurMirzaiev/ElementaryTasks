using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tasks.Interfaces;

namespace Tasks.ChessBoardCore {
    class ParserArgumentsChessBoard : IParserArguments {
        public bool IsValid(string[] args, bool skipFirstArgument)
        {
            bool result = false;

            if (skipFirstArgument)
            {
                args = args.Skip(1).ToArray();
            }

            if(args.Length == 2)
            {
               result = Int32.TryParse(args[0], out int width)
                    && Int32.TryParse(args[1], out int height);
            }

            return result;
        }
    }
}
