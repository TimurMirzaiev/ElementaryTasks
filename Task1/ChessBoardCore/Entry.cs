using Tasks.ChessBoardCore.Enums;

namespace Tasks.ChessBoardCore
{
    class Entry<T> : IEntry
    {

        private T _data;
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
