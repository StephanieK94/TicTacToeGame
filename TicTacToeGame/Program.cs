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

            var player = new Player();
            player.Position = Token.X;

            var newUserMove = new int[] { };
            var isValidMove = false;
            do
            {
                newUserMove = game.GetUserInput(player.Position);
                isValidMove = game.ValidateMove(newUserMove);
            } while (isValidMove != true);

            player.SetUserPosition(newUserMove);

        }
    }
}
