using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!\n");

            var game = new Game();
            var currentBoard = game.CreateNewGame();

            Console.WriteLine("Here's the current board:\n");

            var printer = new Printer();

            printer.PrintBoard(currentBoard);
        }
    }
}
