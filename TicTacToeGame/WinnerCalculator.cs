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
            if (IsRowWinner(player, currentBoard) == false && IsColumnWinner(player, currentBoard) == false 
                && IsDiagonlWinner(player, currentBoard) == false) return false;
            return true;
        }

        public bool IsRowWinner(Player player, Token[,] currentBoard)
        {
            for(var row =0; row<=2; row++)
            {
                if (currentBoard[row, 0] == player.Position && currentBoard[row, 1] == player.Position &&currentBoard[row, 2] == player.Position)
                    return true;
            }
            return false;
        }

        public bool IsColumnWinner(Player player, Token[,] currentBoard)
        {
            for (var col = 0; col <= 2; col++)
            {
                if (currentBoard[0,col] == player.Position && currentBoard[1,col] == player.Position && currentBoard[2,col] == player.Position)
                    return true;
            }
            return false;
        }

        public bool IsDiagonlWinner(Player player, Token[,] currentBoard)
        {
            if ((currentBoard[0,0] == player.Position &&  currentBoard[1,1] == player.Position &&currentBoard[2,2] == player.Position) || (currentBoard[0,2] == player.Position && currentBoard[1,1] == player.Position && currentBoard[2,0] == player.Position)) 
            {
                return true;
            }
            else return false;
        }
    }
}
