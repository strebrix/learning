using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;
enum xOrO { X, O };
enum osAndExes { neither, X, O };
internal static partial class Controller
{
    private static PlayerModel player1 = new PlayerModel(), player2 = new PlayerModel();
    private static BoardModel board = new BoardModel();
    private static StateModel state = new StateModel();
    static Controller()
    {
        player1.name = "Player";
        player1.alias = xOrO.X;
        player2.name = "Computer";
        player2.alias = xOrO.O;

    }

    public static void switchGameState()
    {
        
    }

    static void restartGame()
    {
        player1.score = 0;
        player2.score = 0;
    }


}
