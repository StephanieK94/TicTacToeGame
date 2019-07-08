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

        [Test]
        public void GivenPlayerOne_ReturnCharacterX()
        {
            var player = 'X';

            var game = new TicTacToeGame.Game();
            var turn = game.PlayMove(player);

            Assert.AreEqual(player, turn);
        }

        [Test]
        public void GivenPlayerTwo_ReturnCharacterO()
        {
            var player = 'O';

            var game = new TicTacToeGame.Game();
            var turn = game.PlayMove(player);

            Assert.AreEqual(player, turn);
        }

        [Test]
        public void GivenPlayerX_WhenNextTurn_ReturnPlayerO()
        {
            var player = 'X';

            var game = new TicTacToeGame.Game();
            player = game.ChangePlayer(player);

            Assert.AreEqual('O', player);
        }

        [Test]
        public void GivenPlayerO_WhenNextTurn_ReturnPlayerX()
        {
            var player = 'O';

            var game = new TicTacToeGame.Game();
            player = game.ChangePlayer(player);

            Assert.AreEqual('X', player);
        }
    }
}
