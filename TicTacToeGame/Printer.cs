using System;

namespace TicTacToeGame
{
    public class Printer
    {
        public void PrintWelcome(Token[,] currentBoard)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!\n");
            Console.WriteLine("Here's the current board:\n");

            PrintBoard(currentBoard);
        }

        public void PrintBoard(Token[,] game)
        {
            for (var row = 0; row < 3; row++)
            {
                for (var column = 0; column < 3; column++)
                {
                    if (game[row, column] == Token.Empty) Console.Write(" * ");
                    else Console.Write($" {0} " , game[row, column]);
                }
                Console.WriteLine();
            }
        }

        public void PrintPromptForMove(Player player)
        {
            Console.WriteLine($"Player {0} enter a coord x,y to place your {1} or enter 'q' to give up: ", (int)player.Position, player.Position);

        }

        public void PrintAcceptedMove(Token[,] currentBoard)
        {
            Console.WriteLine("Move accepted, here's the current board:\n");
            PrintBoard(currentBoard);
        }

        public void PrintInvalidRangeErrorMessage()
        {
            Console.WriteLine("Oh no, your coordinates were out of the acceptable range.\n");
            Console.WriteLine("Rows and Columns are 1,2, or 3 based on the board. Try again...\n");
        }

        public void PrintInvalidMoveErrorMessage()
        {
            Console.WriteLine("Oh no, a piece is already in this place! Try again...\n");
        }
    }
}
