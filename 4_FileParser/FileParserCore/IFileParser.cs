namespace _4_FileParser.FileParserCore
{
    public interface IFileParser
    {
        int Count(string path, string line);
        void Replace(string path, string line, string replace);
    }
}