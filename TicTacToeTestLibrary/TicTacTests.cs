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
            var newGame = game.CreateNewGame();

            var expected = new char[3, 3] { {'-','-','-' }, { '-', '-', '-' }, { '-', '-', '-' } };

            Assert.AreEqual(expected, newGame);
        }

        //[Test]
        //public void GivenPlayerOne_ReturnCharacterX()
        //{
        //    var player = 'X';

        //    var turn = game.PlayMove(player);

        //    Assert.AreEqual(player, turn);
        //}

        //[Test]
        //public void GivenPlayerTwo_ReturnCharacterO()
        //{
        //    var player = 'O';

        //    var turn = game.PlayMove(player);

        //    Assert.AreEqual(player, turn);
        //}

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

        //[Test]
        //public void GivenPositions_WhenPlayerMoves_ChangeBoard()
        //{
        //    var player = 'O';
        //    var row = 0;
        //    var column = 0;

        //    var newGame = game.CreateNewGame();

        //    newGame[row,column] = game.PlayMove(player);

        //    Assert.AreEqual('O', newGame[0,0]);
        //}

        //[Test]
        //public void GivenPlayer1Position_WhenPlayer2PlaysSamePosition_ThrowsException()
        //{
        //    var player1 = 'X';
        //    var player2 = 'O';

        //    var row = 0;
        //    var column = 0;

        //    var newGame = game.CreateNewGame();

        //    newGame[row, column] = game.PlayMove(player1, newGame);
        //    newGame[row, column] = game.PlayMove(player2);

        //    Assert.AreEqual('X', newGame[0, 0]);
        //}

        [Test]
        public void GivenCurrentBoard_WhenPlaysMove_ReturnsChangedBoard()
        {
            var player1 = 'X';

            var row = 0;
            var column = 0;

            var newGame = game.CreateNewGame();

            newGame = game.PlayMove(player1, newGame, row, column);
            //var expected = new char[3, 3] { { 'X', '-', '-' }, { '-', '-', '-' }, { '-', '-', '-' } };

            Assert.AreEqual('X', newGame[0, 0]);
        }
    }
}
