using _1_ChessBoard.ChessBoardCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace _1_ChessBoard.Tests
{
    public class ChessBoardCore
    {
        [Fact]
        public void CreateInstance_ChessBoard_Correct()
        {
            //arrange
            int expectedHeight = 3;
            int expectedWidth = 5;
            //act
            ChessBoard actual = ChessBoard.CreateChessBoard(3, 5);
            //assert
            Assert.Equal(expectedHeight, actual.Height);
            Assert.Equal(expectedWidth, actual.Width);
        }

        [Theory]
        [InlineData(0, 5)]
        [InlineData(5, 0)]
        public void CreateInstance_ChessBoard_ArgumentException(int height, int width)
        {
            //assert
            Assert.Throws<ArgumentException>(() => ChessBoard.CreateChessBoard(height, width));
        }

        [Theory]
        [InlineData(-1, 5)]
        [InlineData(5, -1)]
        public void CreateInstance_ChessBoard_ArithmeticException(int height, int width)
        {
            //assert
            Assert.Throws<ArithmeticException>(() => ChessBoard.CreateChessBoard(height, width));
        }

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
