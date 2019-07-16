using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Game
    {
        public Piece[,] board { get; set; }
        public Printer printer = new Printer();

        public Game()
        {
            board = new Piece[,]
            {
                { Piece.Empty, Piece.Empty, Piece.Empty },
                { Piece.Empty, Piece.Empty, Piece.Empty },
                { Piece.Empty, Piece.Empty, Piece.Empty }
            };
        }

        public Piece[,] PlayMove(Player player, Piece[,] board)
        {
            board[player.Row, player.Column] = player.Symbol;
            return board;
        }

        public bool ValidatePosition(Piece player, Piece chosenPosition)
        {
            if (chosenPosition == Piece.Empty)
                return true;
            else printer.PrintInvalidMoveErrorMessage();
                return false;
        }

        public int[] GetUserInput()
        {
            var input = Console.ReadLine().Split(',');
            if (CheckForForfeit(input) == true) EndGame();

            return new int[] { Convert.ToInt32(input[0])-1, Convert.ToInt32(input[1])-1 };
        }

        public bool ValidateMove(int[] moves)
        {
            if ((moves.Length <= 0 || moves.Length > 2) || (moves[0] < 0 || moves[0] > 2 || moves[1] < 0 || moves[1] > 2))
            {
                printer.PrintInvalidRangeErrorMessage();
                return false;
            }
            return true;
        }

        public bool CheckForForfeit(string[] userInput)
        {
            foreach(var input in userInput)
            {
                if (input == "q" || input == "Q") return true;
            }
            return false;
        }
        public void EndGame()
        {
            Environment.Exit(0);
        }
    }
}
