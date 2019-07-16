using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Player
    {
        public Piece Symbol { get; set; }        
        public int Row { get; set; }
        public int Column { get; set; }


        public void SetUserPosition(int[] userMoves)
        {
            this.Row = userMoves[0];
            this.Column = userMoves[1];
        }

        public void ChangePlayer(Player player)
        {
            if (player.Symbol == Piece.X) this.Symbol = Piece.O;
            else this.Symbol = Piece.X;
        }
    }
}
