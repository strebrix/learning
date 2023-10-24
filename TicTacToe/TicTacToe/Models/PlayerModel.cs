using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe;

internal class PlayerModel
{
    public bool isStarting = false;
    public playerDesignation designation;
    public uint score = 0;
    public string name = "";
}
