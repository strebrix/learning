using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;

internal class BoardModel
{
    public boardSpotDescriptor[,] board;
    public bool xWon;
    public bool yWon;

    public BoardModel()
    {
        boardSpotDescriptor[,] board = new boardSpotDescriptor[3, 3];
        xWon = false;
        yWon = false;
    }
}