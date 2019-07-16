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
        private Game game = new Game();
        private Player player = new Player();


        [Test]
        public void GivenPlayer_WhenXPlaysMove_ReturnsChangedBoard()
        {
            player.Symbol = Piece.X;
            player.Row = 0;
            player.Column = 0;

            Game game = new Game();
            var currentBoard = game.board;
            var expected = new Piece[,] { { Piece.X, Piece.Empty, Piece.Empty }, { Piece.Empty, Piece.Empty, Piece.Empty }, { Piece.Empty, Piece.Empty, Piece.Empty } };

            currentBoard = game.PlayMove(player, currentBoard);

            Assert.AreEqual(expected, currentBoard);
        }

        [Test]
        public void GivenPlayer_WhenOPlaysMove_ReturnsChangedBoard()
        {
            player.Symbol = Piece.O;
            player.Row = 1;
            player.Column = 1;

            Game game = new Game();
            var expected = new Piece[,] { { Piece.Empty, Piece.Empty, Piece.Empty }, { Piece.Empty, Piece.O, Piece.Empty }, { Piece.Empty, Piece.Empty, Piece.Empty } };

            game.board = game.PlayMove(player, game.board);

            Assert.AreEqual(expected, game.board);
        }

        [Test]
        [TestCase(Piece.Empty,Piece.X,true)]
        [TestCase(Piece.Empty, Piece.O, true)]
        public void GivenToken_WhenPlayerMoves_ReturnTrueForValidMove(Piece chosenPosition, Piece player, bool isValid)
        {
            isValid = game.ValidatePosition(player, chosenPosition);

            Assert.True(isValid);
        }

        [Test]
        [TestCase(Piece.O, Piece.X, false)]
        [TestCase(Piece.X, Piece.O, false)]
        public void GivenToken_WhenPlayerMoves_ReturnFalseForInvalidMove(Piece chosenPosition, Piece player, bool isValid)
        {
            isValid = game.ValidatePosition(player, chosenPosition);

            Assert.False(isValid);
        }
        
        [Test]
        [TestCase(0, 0, true)]
        [TestCase(1,1,true)]
        [TestCase(2,2,true)]
        [TestCase(3,3,false)]
        [TestCase(-1,1,false)]
        [TestCase(4,0,false)]
        public void GivenConvertedMoves_WhenValidated_ReturnsIfValid(int row, int column, bool expectedValidity)
        {
            var moves = new int[] {row,column};

            var actualValidity = game.ValidateMove(moves);

            Assert.AreEqual(expectedValidity, actualValidity);
        }

        [Test]
        public void GivenEmptyMoves_WhenValidated_ReturnsInvalid()
        {
            var moves = new int[] { };

            var actualValidity = game.ValidateMove(moves);

            Assert.AreEqual(false, actualValidity);
        }

        [Test]
        public void GivenTooManyMoves_WhenValidated_ReturnsInvalid()
        {
            var moves = new int[] {1,1,1 };

            var actualValidity = game.ValidateMove(moves);

            Assert.AreEqual(false, actualValidity);
        }

        [Test]
        public void GivenToken_ReturnTokenAndIntOfToken()
        {
            var symbol = Piece.X;
            var number = (int)Piece.X;

            Assert.AreEqual(Piece.X, symbol);
            Assert.AreEqual(1, number);
        }

        [Test]
        public void GivenToken_ReturnStringWithTokenAndIntOfToken()
        {
            var symbol = Piece.X;
            var number = (int)Piece.X;

            var expected = "Token: X, Player Number: 1";
            var actual = $"Token: {symbol}, Player Number: {number}";

            Assert.AreEqual(expected, actual);
        }
    }
}
