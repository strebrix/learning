using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;

internal static class ProgramState
{
    public static event EventHandler? onGameStateChanged;

    public static bool enableAI = false;
    public static playerDesignation startingType = playerDesignation.X;
    public static bool gameRunning
    {
        get
        {
            return gameRunning;
        }
        set
        {
            gameRunning = value;
            onGameStateChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}
