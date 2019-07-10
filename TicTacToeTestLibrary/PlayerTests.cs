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
        public void GivenPlayerX_WhenNextTurn_ReturnPlayerO()
        {
            player.Position = Token.X;

            player.ChangePlayer(player);

            Assert.AreEqual(Token.O, player.Position);
        }

        [Test]
        public void GivenPlayerO_WhenChangesTurn_ReturnPlayerX()
        {
            player.Position = Token.O;

            player.ChangePlayer(player);

            Assert.AreEqual(Token.X, player.Position);
        }

        [Test]
        public void GivenInputForPosition_ReturnSetPositionForPlayer()
        {
            var row = 2;
            var column = 2;

            player.SetUserPosition(row, column);

            Assert.AreEqual(2, player.Row);
            Assert.AreEqual(2, player.Column);
        }
    }
}
