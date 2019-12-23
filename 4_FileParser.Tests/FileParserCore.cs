using System.IO;
using System.IO.Abstractions.TestingHelpers;
using System.Text;
using Xunit;
using _4_FileParser.FileParserCore;

namespace _4_FileParser.Tests
{
    public class FileParserCore
    {
        private string _path = @"C:\temp\in.txt";

        [Fact]
        public void Count_IsCorrect()
        {
            //arrange
            int expected = 3;
            MockFileSystem mockFileSystem = new MockFileSystem();
            MockFileData mockInputFile = new MockFileData(
                "aaaga\n" +
                "aaaga\n" +
                "gaaaa");
            mockFileSystem.AddFile(_path, mockInputFile);
            var parser = new FileParser(mockFileSystem);
            //act
            int actual = parser.Count(_path, "g");
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Count_FileNotFoundException()
        {
            //arrange
            int expected = 3;
            MockFileSystem mockFileSystem = new MockFileSystem();
            MockFileData mockInputFile = new MockFileData(
                "aaaga\n" +
                "aaaga\n" +
                "gaaaa");
            mockFileSystem.AddFile(_path, mockInputFile);
            var parser = new FileParser(mockFileSystem);
            //assert
            Assert.Throws<FileNotFoundException>(() => 
                parser.Count(_path, "g"));
        }

        [Fact]
        public void Replace_IsCorrect()
        {
            //arrange
            MockFileSystem mockFileSystem = new MockFileSystem();
            FileParser parser = new FileParser(mockFileSystem);

            StringBuilder text = new StringBuilder();
            text.AppendLine("aaaga");
            text.AppendLine("aaaga");
            text.AppendLine("gaaaa");

            MockFileData mockInputFile = new MockFileData(text.ToString());

            StringBuilder expected = new StringBuilder();
            expected.AppendLine("aaafa");
            expected.AppendLine("aaafa");
            expected.AppendLine("faaaa");

            mockFileSystem.AddFile(_path, mockInputFile);
            //act
            parser.Replace(_path, "g", "f");
            StreamReader reader = mockFileSystem.File.OpenText(_path);
            StringBuilder actual = new StringBuilder();

            while (!reader.EndOfStream)
            {
                actual.AppendLine(reader.ReadLine());
            }
            //assert
            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void Replace_FileNotFoundException()
        {
            //arrange
            string path = @"C:\temp\in.txt";
            MockFileSystem mockFileSystem = new MockFileSystem();
            FileParser parser = new FileParser(mockFileSystem);

            StringBuilder text = new StringBuilder();
            text.AppendLine("aaaga");
            text.AppendLine("aaaga");
            text.AppendLine("gaaaa");

            MockFileData mockInputFile = new MockFileData(text.ToString());

            mockFileSystem.AddFile(path, mockInputFile);
            //act
            //assert
            Assert.Throws<FileNotFoundException>(() =>
                            parser.Replace(path + "111", "g", "f"));
        }
    }
}
