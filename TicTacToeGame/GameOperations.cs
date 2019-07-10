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

        public bool ValidatePosition(Token player, Token chosenPosition)
        {
            if (chosenPosition == Token.Empty) return true;
            return false;
        }

        public int[] ConvertUserInput()
        {
            var input = Console.ReadLine().Split(',');
            return new int[] { Convert.ToInt32(input[0])-1, Convert.ToInt32(input[1])-1 };
        }

        public bool ValidateMove(int[] moves)
        {
            if (moves.Length <= 0 || moves.Length > 2) return false;
            if (moves[0] < 1 || moves[0] > 3 || moves[1] < 1 || moves[1] > 3) return false;
            return true;
        }
    }
}
