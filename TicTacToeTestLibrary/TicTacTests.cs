using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeTestLibrary
{
    [TestFixture]
    public class TicTacTests
    {
        [Test]
        public void GivenNewGame_ReturnsGameBoardLayout()
        {
            var game = new TicTacToeGame.Game();

            var newGame = game.NewGame();
            var expected = new char[3, 3] { {'-','-','-' }, { '-', '-', '-' }, { '-', '-', '-' } };

            Assert.AreEqual(expected, newGame);
        }
    }
}
