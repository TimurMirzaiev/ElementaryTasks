using FluentValidation;
using System;

namespace _1_ChessBoard.ChessBoardCore
{
    public class ChessBoardValidator : AbstractValidator<ChessBoard>
    {
        public ChessBoardValidator()
        {
            RuleFor(t => t.Height)
                .GreaterThan(0)
                .LessThan(Int32.MaxValue);

            RuleFor(t => t.Width)
                .GreaterThan(0)
                .LessThan(Int32.MaxValue);
        }
    }
}
