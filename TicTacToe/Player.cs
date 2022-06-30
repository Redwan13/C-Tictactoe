using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public String name;

        public Player(String name)
        {
            this.name = name;
        }

        public void PlayerMove(board gb, char[] move, char pChar)
        {
            gb.Put(pChar, move);
        }
    }
}
