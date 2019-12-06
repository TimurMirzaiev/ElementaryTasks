namespace _1_ChessBoard.ChessBoardCore
{
    class Board<T>
    {

        protected T[,] _board;

        public T this[int column, int row]
        {
            get
            {
                return _board[column, row];
            }
            set
            {
                _board[column, row] = value;
            }
        }
    }
}
