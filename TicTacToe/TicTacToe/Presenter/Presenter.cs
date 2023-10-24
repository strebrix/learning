using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;
enum playerDesignation { X, O };
enum boardSpotDescriptor { neither, X, O };
internal static partial class Presenter
{
    public static PlayerModel player1 = new PlayerModel(), player2 = new PlayerModel();
    static Presenter()
    {
        player1.name = "Player";
        player1.designation = playerDesignation.X;
        player2.name = "Computer";
        player2.designation = playerDesignation.O;

    }


}
