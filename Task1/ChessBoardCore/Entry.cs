using System;
using System.Collections.Generic;
using System.Text;
using Tasks.ChessBoardCore.Enums;

namespace Tasks.ChessBoardCore {
    class Entry<T> : IEntry {

        private T _data;
        private EntryColor _entryColor;

        public EntryColor EntryColor 
        {
            get { return _entryColor; }
            set { _entryColor = value; }
        }

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
