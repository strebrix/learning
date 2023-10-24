using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;
internal static partial class Presenter
{
    public static BoardModel board = new BoardModel();
    public static void loadGameState(string file)
    {
        //TODO
    }
    public static void clearBoard()
    {
        board = new BoardModel();
    }


    
}
