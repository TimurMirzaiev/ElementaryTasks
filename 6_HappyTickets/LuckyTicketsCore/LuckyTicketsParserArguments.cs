using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_LuckyTickets.LuckyTicketsCore
{
    public class LuckyTicketsParserArguments : IParserArguments
    {
        public bool IsValid(string[] args, bool skipFirstArgument = false)
        {
            bool result = false;

            if (skipFirstArgument)
            {
                args = args.Skip(1).ToArray();
            }

            if (args.Length == 1)
            {
                result = true;
            }

            return result;
        }
    }
}
