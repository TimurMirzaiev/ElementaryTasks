using System;
using Xunit;
using _1_ChessBoard.ChessBoardCore;

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
    }
}
