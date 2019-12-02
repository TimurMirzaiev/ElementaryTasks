using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ChessBoardCore {
    class ChessBoard<T> {
        private int height;
        private int width;
        private IEntry<T>[,] entry;

        public ChessBoard(int width, int height, T data)
        {
            this.height = height;
            this.width = width;
            entry = new IEntry<T>[width, height];

            for(int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    entry[i, j] = new Entry<T>(data);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int j = 0; j < height; j++)
            {
                if (j % 2 != 0)
                {
                    sb.Append(" ");
                }
                for (int i = 0; i < width; i++)
                {
                    sb.Append(String.Format("{0} ", entry[i, j]));
                }
                sb.AppendLine();
            }
                
            return sb.ToString();
        }
    }
}
