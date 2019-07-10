using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Player
    {
        public Token Position { get; set; }        
        public int Row { get; set; }
        public int Column { get; set; }


        public void SetUserPosition(int[] userMoves)
        {
            this.Row = userMoves[0];
            this.Column = userMoves[1];
        }

        public void ChangePlayer(Player player)
        {
            if (player.Position == Token.X) this.Position = Token.O;
            else this.Position = Token.X;
        }
    }
}
