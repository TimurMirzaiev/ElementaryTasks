using FluentValidation.Results;
using System;
using _1_ChessBoard.ChessBoardCore.Enums;

namespace _1_ChessBoard.ChessBoardCore
{
    public class ChessBoard : Board<IEntry>
    {
        public int Height { get; private set; }
        public int Width { get; private set; }

        private ChessBoard(int height, int width)
        {
            Height = height;
            Width = width;

            FillBoard(height, width);
        }

        public static ChessBoard CreateChessBoard(int height, int width)
        {
            ChessBoardValidator validator = new ChessBoardValidator();
            ChessBoard chessBoard;

            try
            {
                chessBoard = new ChessBoard(height, width);
            }
            catch (ArithmeticException ex)
            {
                throw new ArithmeticException("ArithmeticException", ex);
            }

            ValidationResult validationResult = validator.Validate(chessBoard);

            if (validationResult.IsValid)
            {
                return chessBoard;
            }

            throw new ArgumentException();
        }

        private void FillBoard(int height, int width)
        {
            EntryColor entryColor;
            _board = new Entry<char>[height, width];

            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    entryColor = EntryColor.Black;

                    if ((row + column) % 2 == 0)
                    {
                        entryColor = EntryColor.White;
                    }

                    _board[row, column] = new Entry<char>('*', entryColor);
                }
            }
        }
    }
}
