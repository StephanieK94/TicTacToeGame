using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class GameOperations
    {
        public Token[,] CreateNewGameBoard()
        {
            return new Token[,] { { Token.Empty, Token.Empty, Token.Empty }, { Token.Empty, Token.Empty, Token.Empty } , { Token.Empty, Token.Empty, Token.Empty } };
        }

        public Token[,] PlayMove(Player player, Token[,] board)
        {
            board[player.Row, player.Column] = player.Position;
            return board;
        }

        public bool ValidateMove(Player player, Token[,] currentBoard)
        {
            if (currentBoard[player.Row, player.Column] == Token.Empty)
            {
                return true;
            }
            return false;
        }
    }
}
