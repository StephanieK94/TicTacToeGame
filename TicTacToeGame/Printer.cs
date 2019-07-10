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
                    else Console.Write($" {game[row, column]} ");
                }
                Console.WriteLine();
            }
        }

        public void PrintPromptForMove(Player player)
        {
            Console.WriteLine($"Player {(int)player.Position} enter a coord x,y to place your {player.Position}: ");
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
