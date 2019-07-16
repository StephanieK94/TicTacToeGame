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
            var game = new Game();
            var currentBoard = game.board;

            var printer = new Printer();
            var playerHasWon = false;
            var turnCount = 0;

            printer.PrintWelcome(currentBoard);

            var player = new Player();


            do
            {
                player.ChangePlayer(player);

                var isValidMove = false;
                var isValidPosition = false;

                do
                {
                    printer.PrintPromptForMove(player);

                    var userInput = Console.ReadLine();

                    if(game.CheckForForfeit(userInput) == true)
                    {
                        playerHasWon = true;
                        isValidMove = true;
                        isValidPosition = true;

                        player.ChangePlayer(player);
                    }
                    else
                    {
                        var newMove = game.ConvertUserInput(userInput);

                        isValidMove = game.ValidateMove(newMove);

                        if (isValidMove == true)
                        {
                            player.SetUserPosition(newMove);

                            isValidPosition = game.ValidatePosition(player.Symbol, currentBoard[player.Row, player.Column]);

                            if (isValidPosition == true)
                            {
                                currentBoard = game.PlayMove(player, currentBoard);

                                printer.PrintAcceptedMove(currentBoard);
                            }
                        }
                    }
                } while (isValidMove != true || isValidPosition != true);

                var winnerCalculator = new WinnerCalculator(player, currentBoard);
                if (winnerCalculator.IsWinner == true) playerHasWon = true;

                turnCount++;

            } while (playerHasWon != true && turnCount != 9);

            // Game ends, declare winner or if draw
            if (playerHasWon == false) printer.PrintDraw();
            else printer.PrintWinner(player);
        }
    }
}
