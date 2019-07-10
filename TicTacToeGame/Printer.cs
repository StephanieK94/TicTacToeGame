using System;

namespace TicTacToeGame
{
    public class Printer
    {
        public void PrintBoard(Token[,] game)
        {
            for (var row = 0; row < 3; row++)
            {
                for (var column = 0; column < 3; column++)
                {
                    if (game[row, column] == Token.Empty) Console.Write(" - ");
                    else Console.Write($" {0} " , game[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}
