using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4_FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            FileParserApp fileParserApp = new FileParserApp();
            fileParserApp.Run(args);
        }
    }
}
