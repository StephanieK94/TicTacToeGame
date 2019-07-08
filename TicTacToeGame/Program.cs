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

            var gamer = new Game();
            var newGame = gamer.CreateNewGame();

            Console.WriteLine("Here's the current board:\n");

            gamer.PrintBoard(newGame);
        }
    }
}
