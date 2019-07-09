using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Game
    {
        private char[,] game;

        public char[,] CreateNewGame()
        {
            return this.game = new char[3,3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
        }
    }
}
