using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;

internal class StateModel
{
    public bool enableAI = false;
    public xOrO startingType = xOrO.X;
    public bool inPlay = false;
}
