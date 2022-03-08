using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        public int point=0;
        public void AddPoint(Player pl)
        {
            pl.point = pl.point + 1;
        }
    }
}
