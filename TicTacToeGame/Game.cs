using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class GameBoard
    {
        private char[,] board;

        public char[,] CreateNewGameBoard()
        {
            return this.board = new char[3,3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
        }
    }
}
