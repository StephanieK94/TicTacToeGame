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
        private GameOperations operations = new GameOperations();
        private Player player = new Player();


        [Test]
        public void GivenNewInstanceOfGame_ReturnsGameBoardLayout()
        {
            var newGame = operations.CreateNewGameBoard();
            var expected = new char[,] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

            Assert.AreEqual(expected, newGame);
        }

        [Test]
        public void GivenPlayerX_WhenPlaysMove_ReturnsChangedBoard()
        {
            player.Token = 'X';
            player.Row = 0;
            player.Column = 0;

            var currentBoard = new char[3, 3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            var expected = new char[3, 3] { { 'X', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

            currentBoard = operations.PlayMove(player, currentBoard);

            Assert.AreEqual(expected, currentBoard);
        }

        [Test]
        public void GivenPlayer_WhenValidatingMoveInNewPosition_ReturnsTrueIfValidMove()
        {
            player.Token = 'X';
            player.Row = 0;
            player.Column = 0;

            var currentBoard = new char[3, 3] { { '-', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

            var isValid = operations.ValidateMove(player, currentBoard);

            Assert.True(isValid);
        }

        [Test]
        public void GivenPlayer_WhenValidatingMoveInSamePosition_ReturnsFalseIfInvalidMove()
        {
            player.Token = 'O';
            player.Row = 0;
            player.Column = 0;

            var currentBoard = new char[3, 3] { { 'X', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };
            var isValid = operations.ValidateMove(player, currentBoard);

            Assert.False(isValid);
        }
    }
}
