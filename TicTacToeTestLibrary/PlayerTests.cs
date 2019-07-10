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
        private GameOperations operations = new GameOperations();
        private Player player = new Player();
        
        [Test]
        [TestCase(Token.X,Token.O)]
        [TestCase(Token.O,Token.X)]
        public void GivenPlayer_WhenNextTurn_ReturnsOtherPlayer(Token player1, Token player2)
        {
            player.Position = player1;

            player.ChangePlayer(player);

            Assert.AreEqual(player2, player.Position);
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(2,2)]
        public void GivenInputForPosition_ReturnSetPositionForPlayer(int row, int column)
        {
            player.SetUserPosition(row, column);

            Assert.AreEqual(row, player.Row);
            Assert.AreEqual(column, player.Column);
        }

        
    }
}
