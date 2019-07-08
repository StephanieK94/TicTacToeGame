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
    public class TicTacTests
    {
        private Game game = new TicTacToeGame.Game();

        [Test]
        public void GivenNewGame_ReturnsGameBoardLayout()
        {
            var currentBoard = game.CreateNewGame();

            var expected = new char[3, 3] { {'-','-','-' }, { '-', '-', '-' }, { '-', '-', '-' } };

            Assert.AreEqual(expected, currentBoard);
        }

        [Test]
        public void GivenPlayerX_WhenNextTurn_ReturnPlayerO()
        {
            var player = 'X';

            player = game.ChangePlayer(player);

            Assert.AreEqual('O', player);
        }

        [Test]
        public void GivenPlayerO_WhenNextTurn_ReturnPlayerX()
        {
            var player = 'O';

            player = game.ChangePlayer(player);

            Assert.AreEqual('X', player);
        }

        [Test]
        public void GivenCurrentBoard_WhenPlaysMove_ReturnsChangedBoard()
        {
            var player1 = 'X';

            var row = 0;
            var column = 0;

            var currentBoard = game.CreateNewGame();

            currentBoard = game.PlayMove(player1, currentBoard, row, column);
            var expected = new char[3, 3] { { 'X', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

            Assert.AreEqual(expected, currentBoard);
        }

        [Test]
        public void GivenCurrentBoard_WhenPlaysMoveInNewPosition_ReturnsTrueIfValidMove()
        {
            var player1 = 'O';

            var row = 0;
            var column = 1;

            var currentBoard = new char[3, 3] { { 'X', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            var isValid = game.ValidateMove(player1, currentBoard, row, column);

            Assert.True(isValid);
        }


    }
}
