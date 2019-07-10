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

            var winnerCalculator = new WinnerCalculator();

            var printer = new Printer();
            var gameEnd = false;
            var turnCount = 0;

            printer.PrintWelcome(currentBoard);

            var player = new Player();
            player.Position = Token.O;

            do
            {
                player.ChangePlayer(player.Position);

                var isValidMove = false;
                var isValidPosition = false;

                do
                {
                    printer.PrintPromptForMove(player);

                    var newUserMove = game.GetUserInput();

                    isValidMove = game.ValidateMove(newUserMove);

                    

                    if (isValidMove == true)
                    {
                        player.SetUserPosition(newUserMove);

                        isValidPosition = game.ValidatePosition(player.Position, currentBoard[player.Row, player.Column]);

                        if (isValidPosition == true)
                        {
                            currentBoard = game.PlayMove(player, currentBoard);
                        }
                    }

                } while (isValidMove != true || isValidPosition != true);

                printer.PrintAcceptedMove(currentBoard);

                gameEnd = winnerCalculator.CalculateIfWinner(player, currentBoard);
                turnCount++;

            } while (gameEnd != true && turnCount != 9);

            // Game ends, declare winner or if draw
            if (gameEnd == false) printer.PrintDraw();
            else printer.PrintWinner(player);
        }
    }
}
