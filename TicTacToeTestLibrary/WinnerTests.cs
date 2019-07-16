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
                var currentBoard = new Piece[,] 
                { 
                    { Piece.X, Piece.Empty, Piece.Empty }, 
                    { Piece.X, Piece.Empty, Piece.Empty }, 
                    { Piece.X, Piece.Empty, Piece.Empty }
                };

                var player = new Player() { Symbol = Piece.X, Row = 0, Column= 0 };

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.True(winnerCalculator.IsWinner);
            }

            [Test]
            public void GivenRowWin_ReturnWinnerTrue()
            {
                var currentBoard = new Piece[,]
                {
                    { Piece.X, Piece.X, Piece.X },
                    { Piece.Empty, Piece.Empty, Piece.Empty },
                    { Piece.Empty, Piece.Empty, Piece.Empty }
                };

                var player = new Player() { Symbol = Piece.X, Row = 0, Column = 2 };

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.True(winnerCalculator.IsWinner);
            }

            [Test]
            public void GivenDiagonalWin_ReturnWinnerTrue()
            {
                var currentBoard = new Piece[,]
                {
                    { Piece.X, Piece.Empty, Piece.Empty },
                    { Piece.Empty, Piece.X, Piece.Empty },
                    { Piece.Empty, Piece.Empty, Piece.X }
                };

                var player = new Player() { Symbol = Piece.X , Row = 0, Column = 0};

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.True(winnerCalculator.IsWinner);
            }

            [Test]
            public void GivenReverseDiagonalWin_ReturnWinnerTrue()
            {
                var currentBoard = new Piece[,]
                {
                    { Piece.X, Piece.O, Piece.X },
                    { Piece.O, Piece.X, Piece.O },
                    { Piece.X, Piece.Empty, Piece.O }
                };

                var player = new Player() { Symbol = Piece.X, Row = 0, Column = 2 };

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.True(winnerCalculator.IsWinner);
            }

            [Test]
            public void GivenFullBoard_ReturnWinnerIsEqualToFalse()
            {
                var currentBoard = new Piece[,]
                {
                    { Piece.X, Piece.X, Piece.O },
                    { Piece.O, Piece.O, Piece.X },
                    { Piece.X, Piece.O, Piece.X }
                };

                var player = new Player() { Symbol = Piece.X };

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.AreEqual(false, winnerCalculator.IsWinner);
            }

            [Test]
            public void GivenSingleMove_ReturnWinnerIsEqualToFalse()
            {
                var currentBoard = new Piece[,]
                {
                    { Piece.X, Piece.Empty, Piece.Empty },
                    { Piece.Empty, Piece.Empty, Piece.Empty },
                    { Piece.Empty, Piece.Empty, Piece.Empty }
                };

                var player = new Player() { Symbol = Piece.X, Row = 0, Column = 0 };

                WinnerCalculator winnerCalculator = new WinnerCalculator(player, currentBoard);

                Assert.AreEqual(false, winnerCalculator.IsWinner);
            }
        }
    }
}
