using _4_FileParser.FileParserCore;
using System;
using System.IO.Abstractions;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4_FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            FileParserApp fileParserApp = new FileParserApp(new FileParser(new FileSystem()));
            fileParserApp.Run(args);
        }
    }
}
