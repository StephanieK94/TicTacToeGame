using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class WinnerCalculator
    {
        public bool CalculateIfWinner(Token[,] currentBoard)
        {
            if (currentBoard[0,0].Equals(currentBoard[1, 0]) && currentBoard[0, 0].Equals(currentBoard[2,0])) return true;
            if (currentBoard[0,0].Equals(currentBoard[0, 1]) && currentBoard[0, 0].Equals(currentBoard[0,2])) return true;
            else return false;
        }

    }
}
