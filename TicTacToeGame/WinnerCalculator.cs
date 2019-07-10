using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class WinnerCalculator
    {
        public bool CalculateIfWinner(Player player, Token[,] currentBoard)
        {
            if (player.Position == currentBoard[0,0] && player.Position == currentBoard[0, 1] && player.Position == currentBoard[0,2]) 
                return true;
            if (player.Position == currentBoard[0, 0] && player.Position == currentBoard[1,0] && player.Position == currentBoard[2,0])
                return true;
            else return false;
        }

    }
}
