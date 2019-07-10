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

            do
            {
                printer.PrintWelcome(currentBoard);

                var player = new Player();
                player.Position = Token.X;

                var isValidMove = false;

                do
                {
                    printer.PrintPromptForMove(player);

                    var newUserMove = game.GetUserInput();
                    isValidMove = game.ValidateMove(newUserMove);

                    if (isValidMove == true)
                    {
                        player.SetUserPosition(newUserMove);
                        currentBoard = game.PlayMove(player, currentBoard);
                    }
                    else if (isValidMove == false) printer.PrintInvalidMoveErrorMessage();

                } while (isValidMove != true);

                printer.PrintAcceptedMove(currentBoard);
                player.ChangePlayer(player.Position); 
            } while (true);
        }
    }
}
