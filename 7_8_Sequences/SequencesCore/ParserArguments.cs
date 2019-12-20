using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_8_Sequences.SequencesCore
{
    class ParserArguments
    {
        public bool IsValidCommandFibonaccy(string[] args)
        {
            bool res = false;

            if (args.Length == 2
                && AreIntegers(args))
            {
                res = true;
            }

            return res;
        }

        public bool IsValidCommandSquareLessThan(string[] args)
        {
            bool res = false;

            if (args.Length == 1
                && AreIntegers(args))
            {
                res = true;
            }

            return res;
        }

        private bool AreIntegers(string[] args)
        {
            bool res = true;

            for(int i = 0; i < args.Length; i++)
            {
                res = Int32.TryParse(args[i], out int arg);
                
                if(res == false)
                {
                    return res;
                }
            }

            return res;
        }
    }
}
