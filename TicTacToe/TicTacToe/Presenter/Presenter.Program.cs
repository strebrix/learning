using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;
internal static partial class Presenter
{

    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }


    public static bool lockBoard = true;
    public static bool lockControls = false;

    public static void switchGameState()
    {
        if (ProgramState.gameRunning)
        {
            ProgramState.gameRunning = false;
            lockBoard = true;
            lockControls = false;
        }
        else
        {
            ProgramState.gameRunning = true;
            lockBoard = false;
            lockControls = true;
        }
        
    }

    public static void restartGame()
    {
        player1.score = 0;
        player2.score = 0;
        Presenter.clearBoard();
    }

}
