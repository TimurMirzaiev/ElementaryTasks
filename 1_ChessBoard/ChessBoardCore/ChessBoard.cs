using _1_ChessBoard.ChessBoardCore.Enums;
using FluentValidation.Results;
using System;

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
            _board = new Entry<char>[width, height];
            EntryColor entryColor;

            for (int row = 0; row < width; row++)
            {
                for (int column = 0; column < height; column++)
                {
                    entryColor = EntryColor.Black;

                    if ((row + column) % 2 == 0)
                    {
                        entryColor = EntryColor.White;
                    }

                    _board[row, width] = new Entry<char>('*', entryColor);
                }
            }
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
    }
}
