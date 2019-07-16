using System;

namespace TicTacToeGame
{
    public class Printer
    {
        public void PrintWelcome(Piece[,] currentBoard)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!\n");
            Console.WriteLine("Here's the current board:\n");

            PrintBoard(currentBoard);
        }

        public void PrintBoard(Piece[,] game)
        {
            for (var row = 0; row < 3; row++)
            {
                Console.WriteLine();

                for (var column = 0; column < 3; column++)
                {
                    if (game[row, column] == Piece.Empty) Console.Write(" * ");
                    else Console.Write($" {game[row, column]} ");
                }

                Console.WriteLine();
            }
        }

        public void PrintPromptForMove(Player player)
        {
            Console.WriteLine($"Player {(int)player.Symbol} enter a coord x,y to place your {player.Symbol}: ");
        }

        public void PrintAcceptedMove(Piece[,] currentBoard)
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

        public void PrintWinner(Player player)
        {
            Console.WriteLine($"Well done {player.Symbol}, you won the game!\n");
        }

        public void PrintDraw()
        {
            Console.WriteLine("It was a Draw! Better luck next time. \n");
        }
    }
}
