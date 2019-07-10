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
            isValid = operations.ValidateMove(player, chosenPosition);

            Assert.True(isValid);
        }

        [Test]
        [TestCase(Token.O, Token.X, false)]
        [TestCase(Token.X, Token.O, false)]
        public void GivenToken_WhenPlayerMoves_ReturnFalseForInvalidMove(Token chosenPosition, Token player, bool isValid)
        {
            isValid = operations.ValidateMove(player, chosenPosition);

            Assert.False(isValid);
        }
        
    }
}
