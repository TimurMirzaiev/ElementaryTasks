using System.IO.Abstractions;
using _4_FileParser.FileParserCore;

namespace _4_FileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            FileParserApp fileParserApp = new FileParserApp(new FileParser());
            fileParserApp.Run(args);
        }
    }
}
