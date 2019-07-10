using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Player
    {
        public Token Position { get; set; }        
        public int Row { get; set; }
        public int Column { get; set; }
    }
}
