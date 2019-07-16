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

                    var newUserMove = game.GetUserInput();

                    isValidMove = game.ValidateMove(newUserMove);

                    

                    if (isValidMove == true)
                    {
                        player.SetUserPosition(newUserMove);

                        isValidPosition = game.ValidatePosition(player.Symbol, currentBoard[player.Row, player.Column]);

                        if (isValidPosition == true)
                        {
                            currentBoard = game.PlayMove(player, currentBoard);
                        }
                    }

                } while (isValidMove != true || isValidPosition != true);

                printer.PrintAcceptedMove(currentBoard);

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
