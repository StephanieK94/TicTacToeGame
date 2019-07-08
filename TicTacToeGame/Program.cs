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
            Console.WriteLine("Welcome to Tic Tac Toe!");

            var gamer = new Game();
            var newGame = gamer.NewGame();

            for(var row = 0; row < 3; row++)
            {
                for(var column=0; column<3;column++)
                {
                    Console.Write(newGame[row, column]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
