using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.ChessBoardCore {
    class ChessBoardDrawer 
    {

        public void Draw(ChessBoard chessBoard)
        {
            StringBuilder res = new StringBuilder();
            for(int j=0; j < chessBoard.Width; j++)
            {
                if(j % 2 != 0)
                {
                    res.Append(String.Format(" "));
                }

                for(int i=0; i < chessBoard.Height; i++)
                {
                    res.Append(String.Format("{0} ", chessBoard[j, i]));
                }
                res.AppendLine();
            }
            Console.WriteLine(res.ToString());
        }
    }
}
