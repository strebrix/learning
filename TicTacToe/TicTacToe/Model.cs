using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToeModel
    {
        enum osAndExes { neither, ex, o};
        private osAndExes[][] board = new osAndExes[3][3];
        public TicTacToeModel()
        {
            resetBoard();
        }

        private void resetBoard()
        {
            board = new osAndExes[3][3];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        board[i][j] = osAndExes.neither;
            //    }
            //}
        }

    }
}
