using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Game
    {
        public char[,] CreateNewGame()
        {
            return new char[3, 3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
        }

        public void PrintBoard(char[,] game)
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

        public char[,] PlayMove(char player, char[,] gameBoard, int row, int column)
        {
            gameBoard[row, column] = player;
            return gameBoard;
        }

        public char ChangePlayer(char player)
        {
            if (player == 'X')
            {
                return 'O';
            }
            else return 'X';
        }
    }
}
