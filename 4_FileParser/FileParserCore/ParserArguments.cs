using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_FileParser.FileParserCore
{
    class ParserArguments : IParserArguments
    {
        public bool IsValid(string[] args, bool skipFirstArgument = false)
        {
            bool res = false;

            if (skipFirstArgument)
            {
                args = args.Skip(1).ToArray();
            }

            if(args.Length == 1)
            {
                res = true;
            }

            return res;
        }

        public bool IsValidCommandCounting(string[] args)
        {
            bool res = false;

            if(args.Length == 2)
            {
                res = true;
            }

            return res;
        }

        public bool IsValidCommandReplace(string[] args)
        {
            bool res = false;

            if (args.Length == 3)
            {
                res = true;
            }

            return res;
        }
    }
}
