using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeGame;

namespace TicTacToeTestLibrary
{
    public class WinnerTests
    {
        [TestFixture]
        public class WinningTests
        {
            //private WinnerCalculator winnerCalculator = new WinnerCalculator();

            [Test]
            public void GivenColumnWin_ReturnWinnerTrue()
            {
                var currentBoard = new Token[,] 
                { 
                    { Token.X, Token.Empty, Token.Empty }, 
                    { Token.X, Token.Empty, Token.Empty }, 
                    { Token.X, Token.Empty, Token.Empty }
                };

                var player = new Player() { Position = Token.X, Row = 0, Column= 0 };

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.True(winnerCalculator.IsWinner);
            }

            [Test]
            public void GivenRowWin_ReturnWinnerTrue()
            {
                var currentBoard = new Token[,]
                {
                    { Token.X, Token.X, Token.X },
                    { Token.Empty, Token.Empty, Token.Empty },
                    { Token.Empty, Token.Empty, Token.Empty }
                };

                var player = new Player() { Position = Token.X, Row = 0, Column = 2 };

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.True(winnerCalculator.IsWinner);
            }

            [Test]
            public void GivenDiagonalWin_ReturnWinnerTrue()
            {
                var currentBoard = new Token[,]
                {
                    { Token.X, Token.Empty, Token.Empty },
                    { Token.Empty, Token.X, Token.Empty },
                    { Token.Empty, Token.Empty, Token.X }
                };

                var player = new Player() { Position = Token.X , Row = 0, Column = 0};

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.True(winnerCalculator.IsWinner);
            }

            [Test]
            public void GivenReverseDiagonalWin_ReturnWinnerTrue()
            {
                var currentBoard = new Token[,]
                {
                    { Token.X, Token.O, Token.X },
                    { Token.O, Token.X, Token.O },
                    { Token.X, Token.Empty, Token.O }
                };

                var player = new Player() { Position = Token.X, Row = 0, Column = 2 };

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.True(winnerCalculator.IsWinner);
            }

            [Test]
            public void GivenFullBoard_ReturnWinnerIsEqualToFalse()
            {
                var currentBoard = new Token[,]
                {
                    { Token.X, Token.X, Token.O },
                    { Token.O, Token.O, Token.X },
                    { Token.X, Token.O, Token.X }
                };

                var player = new Player() { Position = Token.X };

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.AreEqual(false, winnerCalculator.IsWinner);
            }

            [Test]
            public void GivenSingleMove_ReturnWinnerIsEqualToFalse()
            {
                var currentBoard = new Token[,]
                {
                    { Token.X, Token.Empty, Token.Empty },
                    { Token.Empty, Token.Empty, Token.Empty },
                    { Token.Empty, Token.Empty, Token.Empty }
                };

                var player = new Player() { Position = Token.X, Row = 0, Column = 0 };

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.AreEqual(false, winnerCalculator.IsWinner);
            }
        }
    }
}
