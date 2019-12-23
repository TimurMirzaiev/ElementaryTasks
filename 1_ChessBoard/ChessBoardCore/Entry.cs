using _1_ChessBoard.ChessBoardCore.Enums;

namespace _1_ChessBoard.ChessBoardCore
{
    public class Entry<T> : IEntry
    {
        private readonly T _data;
        public EntryColor EntryColor { get; set; }

        public Entry(T data, EntryColor entryColor)
        {
            _data = data;
            EntryColor = entryColor;
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}
