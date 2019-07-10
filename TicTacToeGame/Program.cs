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
            var game = new GameOperations();
            var currentBoard = game.CreateNewGameBoard();

            var printer = new Printer();

            printer.PrintWelcome(currentBoard);

            
        }
    }
}
