using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ChessBoardCore {
    class Entry<T>: IEntry<T> {
        readonly T data;
        public Entry(T data)
        {
            this.data = data;
        }
        public override string ToString()
        {
            return data.ToString();
        }
    }
}
