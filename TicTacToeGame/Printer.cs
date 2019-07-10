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
    }
}
