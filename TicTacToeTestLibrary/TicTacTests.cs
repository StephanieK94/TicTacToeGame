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
            var expected = new Token[,] { { Token.Empty, Token.Empty, Token.Empty }, { Token.Empty, Token.Empty, Token.Empty }, { Token.Empty, Token.Empty, Token.Empty } };

            Assert.AreEqual(expected, newGame);
        }

        [Test]
        public void GivenPlayer_WhenXPlaysMove_ReturnsChangedBoard()
        {
            player.Position = Token.X;
            player.Row = 0;
            player.Column = 0;

            var currentBoard = new Token[,] { { Token.Empty, Token.Empty, Token.Empty }, { Token.Empty, Token.Empty, Token.Empty }, { Token.Empty, Token.Empty, Token.Empty } };
            var expected = new Token[,] { { Token.X, Token.Empty, Token.Empty }, { Token.Empty, Token.Empty, Token.Empty }, { Token.Empty, Token.Empty, Token.Empty } };

            currentBoard = operations.PlayMove(player, currentBoard);

            Assert.AreEqual(expected, currentBoard);
        }

        [Test]
        public void GivenPlayer_WhenOPlaysMove_ReturnsChangedBoard()
        {
            player.Position = Token.O;
            player.Row = 1;
            player.Column = 1;

            var currentBoard= new Token[,] { { Token.X, Token.Empty, Token.Empty }, { Token.Empty, Token.Empty, Token.Empty }, { Token.Empty, Token.Empty, Token.Empty } };
            var expected = new Token[,] { { Token.X, Token.Empty, Token.Empty }, { Token.Empty, Token.O, Token.Empty }, { Token.Empty, Token.Empty, Token.Empty } };

            currentBoard = operations.PlayMove(player, currentBoard);

            Assert.AreEqual(expected, currentBoard);
        }

        [Test]
        [TestCase(Token.Empty,Token.X,true)]
        [TestCase(Token.Empty, Token.O, true)]
        public void GivenToken_WhenPlayerMoves_ReturnTrueForValidMove(Token chosenPosition, Token player, bool isValid)
        {
            isValid = operations.ValidatePosition(player, chosenPosition);

            Assert.True(isValid);
        }

        [Test]
        [TestCase(Token.O, Token.X, false)]
        [TestCase(Token.X, Token.O, false)]
        public void GivenToken_WhenPlayerMoves_ReturnFalseForInvalidMove(Token chosenPosition, Token player, bool isValid)
        {
            isValid = operations.ValidatePosition(player, chosenPosition);

            Assert.False(isValid);
        }
        
        [Test]
        [TestCase(0, 0, true)]
        [TestCase(1,1,true)]
        [TestCase(2,2,true)]
        [TestCase(3,3,false)]
        [TestCase(-1,1,false)]
        [TestCase(4,0,false)]
        public void GivenConvertedMoves_WhenValidated_ReturnsValid(int row, int column, bool expectedValidity)
        {
            var moves = new int[] {row,column};

            var actualValidity = operations.ValidateMove(moves);

            Assert.AreEqual(expectedValidity, actualValidity);
        }

        [Test]
        public void GivenEmptyMoves_WhenValidated_ReturnsInvalid()
        {
            var moves = new int[] { };

            var actualValidity = operations.ValidateMove(moves);

            Assert.AreEqual(false, actualValidity);
        }

        [Test]
        public void GivenTooManyMoves_WhenValidated_ReturnsInvalid()
        {
            var moves = new int[] {1,1,1 };

            var actualValidity = operations.ValidateMove(moves);

            Assert.AreEqual(false, actualValidity);
        }

        [Test]
        public void GivenToken_ReturnTokenAndIntOfToken()
        {
            var symbol = Token.X;
            var number = (int)Token.X;

            Assert.AreEqual(Token.X, symbol);
            Assert.AreEqual(1, number);
        }

        [Test]
        public void GivenToken_ReturnStringWithTokenAndIntOfToken()
        {
            var symbol = Token.X;
            var number = (int)Token.X;

            var expected = "Token: X, Player Number: 1";
            var actual = $"Token: {symbol}, Player Number: {number}";

            Assert.AreEqual(expected, actual);
        }
    }
}
