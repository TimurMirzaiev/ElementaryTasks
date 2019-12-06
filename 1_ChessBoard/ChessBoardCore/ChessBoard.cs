using _1_ChessBoard.ChessBoardCore.Enums;

namespace _1_ChessBoard.ChessBoardCore
{
    class ChessBoard : Board<IEntry>
    {

        private int _height;
        private int _width;

        public int Height
        {
            get { return _height; }
            private set { _height = value; }
        }

        public int Width
        {
            get { return _width; }
            private set { _width = value; }
        }

        public ChessBoard(int height, int width)
        {
            Height = height;
            Width = width;
            _board = new Entry<char>[width, height];

            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    EntryColor entryColor = EntryColor.Black;
                    if ((row + column) % 2 == 0)
                    {
                        entryColor = EntryColor.White;
                    }

                    _board[column, row] = new Entry<char>('*', entryColor);
                }
            }
        }
    }
}
