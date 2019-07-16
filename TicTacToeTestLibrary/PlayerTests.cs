using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame;

namespace TicTacToeTestLibrary
{
    [TestFixture]
    public class PlayerTests
    {
        private Game operations = new Game();
        private Player player = new Player();
        
        [Test]
        [TestCase(Piece.X,Piece.O)]
        [TestCase(Piece.O,Piece.X)]
        [TestCase(Piece.Empty,Piece.X)]
        public void GivenPlayer_WhenNextTurn_ReturnsOtherPlayer(Piece piece1, Piece piece2)
        {
            player.Symbol = piece1;
            player.ChangePlayer(player);

            Assert.AreEqual(piece2, player.Symbol);
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(2,2)]
        public void GivenInputForPosition_ReturnSetPositionForPlayer(int row, int column)
        {
            var moves = new int[] { row, column };
            player.SetUserPosition(moves);

            Assert.AreEqual(row, player.Row);
            Assert.AreEqual(column, player.Column);
        }


    }
}
