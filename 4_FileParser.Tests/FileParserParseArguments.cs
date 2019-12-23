using Xunit;
using _4_FileParser.FileParserCore;

namespace _4_FileParser.Tests
{
    public class FileParserParseArguments
    {
        [Theory]
        [InlineData("a")]
        [InlineData("5")]
        public void ParseArguments_IsValid_SecondArgFalse_ReturnsTrue(params string[] args)
        {
            //arrange
            ParserArguments parserArguments = new ParserArguments();
            bool expected = true;
            //act
            bool actual = parserArguments.IsValid(args);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("5", "5")]
        public void ParseArguments_IsValid_SecondArgTrue_ReturnsTrue(params string[] args)
        {
            //arrange
            ParserArguments parserArguments = new ParserArguments();
            bool expected = true;
            //act
            bool actual = parserArguments.IsValid(args, true);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "a", "a")]
        [InlineData("5", "5", "5")]
        public void ParseArguments_IsValid_ReturnsFalse(params string[] args)
        {
            //arrange
            ParserArguments parserArguments = new ParserArguments();
            bool expected = false;
            //act
            bool actual = parserArguments.IsValid(args);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "a", "a")]
        [InlineData("5", "5", "5")]
        public void ParseArguments_IsValidCommandCounting_ReturnsFalse(params string[] args)
        {
            //arrange
            ParserArguments parserArguments = new ParserArguments();
            bool expected = false;
            //act
            bool actual = parserArguments.IsValidCommandCounting(args);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("5", "5")]
        public void ParseArguments_IsValidCommandCounting_ReturnsTrue(params string[] args)
        {
            //arrange
            ParserArguments parserArguments = new ParserArguments();
            bool expected = true;
            //act
            bool actual = parserArguments.IsValidCommandCounting(args);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "a", "a")]
        [InlineData("5", "5", "5")]
        public void ParseArguments_IsValidCommandReplace_ReturnsTrue(params string[] args)
        {
            //arrange
            ParserArguments parserArguments = new ParserArguments();
            bool expected = true;
            //act
            bool actual = parserArguments.IsValidCommandReplace(args);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "a")]
        [InlineData("5", "5")]
        public void ParseArguments_IsValidCommandReplace_ReturnsFalse(params string[] args)
        {
            //arrange
            ParserArguments parserArguments = new ParserArguments();
            bool expected = false;
            //act
            bool actual = parserArguments.IsValidCommandReplace(args);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
