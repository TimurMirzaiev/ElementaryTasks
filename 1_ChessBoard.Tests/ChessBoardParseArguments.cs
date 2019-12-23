using Xunit;
using _1_ChessBoard.ChessBoardCore;

namespace _1_ChessBoard.Tests
{
    public class ChessBoardParseArguments
    {
        [Theory]
        [InlineData("1", "0")]
        [InlineData("1", "-1")]
        public void ParseArguments_SecondArgFalse_ReturnsTrue(params string[] args)
        {
            //arrange
            ParserArgumentsChessBoard parserArguments = new ParserArgumentsChessBoard();
            bool expected = true;
            //act
            bool actual = parserArguments.IsValid(args);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("b", "1", "-1")]
        public void ParseArguments_SkipFirstArgumentTrue_IsCorrect(params string[] args)
        {
            //arrange
            ParserArgumentsChessBoard parserArguments = new ParserArgumentsChessBoard();
            bool expected = true;
            //act
            bool actual = parserArguments.IsValid(args, true);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("b", "b")]
        [InlineData("b", "0")]
        [InlineData("0", "b")]
        public void ParseArguments_ReturnsFalse(params string[] args)
        {
            //arrange
            ParserArgumentsChessBoard parserArguments = new ParserArgumentsChessBoard();
            bool expected = false;
            //act
            bool actual = parserArguments.IsValid(args);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
