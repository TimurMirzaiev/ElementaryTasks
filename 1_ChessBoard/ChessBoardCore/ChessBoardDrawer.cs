using System;
using System.Text;

namespace _1_ChessBoard.ChessBoardCore
{
    class ChessBoardDrawer
    {

        public void Draw(ChessBoard chessBoard)
        {
            StringBuilder res = new StringBuilder();

            for (int j = 0; j < chessBoard.Height; j++)
            {
                if (j % 2 != 0)
                {
                    res.Append(string.Format(" "));
                }

                for (int i = 0; i < chessBoard.Width; i++)
                {
                    res.Append(string.Format("{0} ", chessBoard[j, i]));
                }
                res.AppendLine();
            }

            Console.WriteLine(res.ToString());
        }
    }
}
