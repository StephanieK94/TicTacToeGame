using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class WinnerCalculator
    {
        public bool WinRow { get; set; }
        public bool WinColumn { get; set; }
        public bool WinDiagonal { get; set; }
        public bool WinRevDiagonal { get; set; }

        public bool IsWinner{get;set;}

        public WinnerCalculator( Player player, Piece[,] board )
        {
            WinRow = true;
            WinColumn = true;
            WinDiagonal = true;
            WinRevDiagonal = true;
            IsWinner = false;

            for(var i = 0; i <= 2; i++)
            {
                if(board[player.Row, i] != player.Symbol) WinRow = false;
                if(board[i, player.Column] != player.Symbol) WinColumn = false;
                if(board[i, i] != player.Symbol) WinDiagonal = false;
                if(board[i, (3 - 1 - i)] != player.Symbol) WinRevDiagonal = false;
            }

            IsWinner = (WinRow || WinColumn || WinDiagonal || WinRevDiagonal);
        }
    }
}
