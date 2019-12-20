using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4_FileParser.FileParserCore
{
    class FileParser
    {

        public int Count(string path, string line)
        {
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
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
                //log
                throw new FileNotFoundException();
            }
        }
        
        public void Replace(string path, string line, string replace)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(path);
                string backup = "backup.txt";
                string thisLine = string.Empty;
                string bufferFile = Path.GetTempFileName();
                string newLine = string.Empty;
                DirectoryInfo directory = fileInfo.Directory;

                File.Copy(path, $@"{fileInfo.Directory}\{backup}", true);

                StreamReader reader = new StreamReader(path);
                StreamWriter writer = new StreamWriter(bufferFile);

                while (!reader.EndOfStream)
                {
                    thisLine = reader.ReadLine();
                    newLine = thisLine.Replace(line, replace);
                    writer.WriteLine(newLine);
                }
                reader.Close();
                writer.Close();
                File.Delete(path);
                File.Move(bufferFile, $@"{directory.FullName}\{fileInfo.Name}");
            }
            catch (IOException ex)
            {
                //Log.Logger.Error($"{ex.Message}");
                throw ex;
            }
        }
    }
}
