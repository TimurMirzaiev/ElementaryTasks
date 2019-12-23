using System.IO;
using System.IO.Abstractions;
using System.Text.RegularExpressions;

namespace _4_FileParser.FileParserCore
{
    public class FileParser : IFileParser
    {
        private readonly IFileSystem _fileSystem;

        public FileParser(IFileSystem fileSystem = null)
        {
            _fileSystem = fileSystem ?? new FileSystem();
        }

        public int Count(string path, string line)
        {
            if (_fileSystem.File.Exists(path))
            {
                using (StreamReader reader = _fileSystem.File.OpenText(path))
                {
                    string thisLine = string.Empty;
                    int count = 0;

                    while (!reader.EndOfStream)
                    {
                        thisLine = reader.ReadLine();
                        count += Regex.Matches(thisLine, line).Count;
                    }

                    return count;
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        public void Replace(string path, string line, string replace)
        {
            try
            {
                IFileInfo fileInfo = _fileSystem.FileInfo.FromFileName(path);
                string backup = "backup.txt";
                string thisLine = string.Empty;
                string bufferFile = _fileSystem.Path.GetTempFileName();
                string newLine = string.Empty;
                IDirectoryInfo directory = fileInfo.Directory;

                _fileSystem.File.Copy(path, $@"{fileInfo.Directory}\{backup}", true);

                using (StreamReader reader = _fileSystem.File.OpenText(path))
                using (StreamWriter writer = _fileSystem.File.CreateText(bufferFile))
                {
                    while (!reader.EndOfStream)
                    {
                        thisLine = reader.ReadLine();
                        newLine = thisLine.Replace(line, replace);
                        writer.WriteLine(newLine);
                    }
                }

                _fileSystem.File.Delete(path);
                _fileSystem.File.Move(bufferFile, $@"{directory.FullName}\{fileInfo.Name}");

            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException("Incorrect path", ex);
            }
        }
    }
}
