using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class GameOperations
    {
        public char[,] CreateNewGameBoard()
        {
            return new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
        }

        public char[,] PlayMove(Player player, char[,] board)
        {
            board[player.Row, player.Column] = player.Token;
            return board;
        }

        public char ChangePlayer(Player player)
        {
            if (player.Token == 'X')
            {
                return 'O';
            }
            else return 'X';
        }

        public bool ValidateMove(Player player, char[,] currentBoard)
        {
            if (currentBoard[player.Row, player.Column] == '-')
            {
                return true;
            }
            return false;
        }
    }
}
