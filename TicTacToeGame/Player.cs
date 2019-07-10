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


        public void SetUserPosition(int userRow, int userColumn)
        {
            this.Row = userRow;
            this.Column = userColumn;
        }

        public void ChangePlayer(Player player)
        {
            if (player.Position == Token.X) this.Position = Token.O;
            else this.Position = Token.X;
        }

    }
}
