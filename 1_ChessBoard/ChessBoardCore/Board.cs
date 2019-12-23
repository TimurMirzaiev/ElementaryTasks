namespace _1_ChessBoard.ChessBoardCore
{
    public class Board<T>
    {

        protected T[,] _board;

        public T this[int row, int column]
        {
            get
            {
                return _board[row, column];
            }
            set
            {
                _board[row, column] = value;
            }
        }
    }
}
