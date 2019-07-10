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
                    Console.Write(game[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}
