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
            [Test]
            public void GivenColumn1_ReturnWinner()
            {
                var currentBoard = new Token[,] 
                { 
                    { Token.X, Token.Empty, Token.Empty }, 
                    { Token.X, Token.Empty, Token.Empty }, 
                    { Token.X, Token.Empty, Token.Empty }
                };

                var player = new Player() { Position = Token.X };

                var winnerCalculator = new WinnerCalculator();
                var isWinner = winnerCalculator.CalculateIfWinner(player, currentBoard);

                Assert.True(isWinner);
            }

            [Test]
            public void GivenColumn2_ReturnWinner()
            {
                var currentBoard = new Token[,]
                {
                    { Token.Empty, Token.X, Token.Empty },
                    { Token.Empty, Token.X, Token.Empty },
                    { Token.Empty, Token.X, Token.Empty },

                };

                var player = new Player() { Position = Token.X };

                var winnerCalculator = new WinnerCalculator();
                var isWinner = winnerCalculator.IsColumnWinner(player, currentBoard);

                Assert.True(isWinner);
            }

            [Test]
            public void GivenRow1_ReturnWinner()
            {
                var currentBoard = new Token[,]
                {
                    { Token.X, Token.X, Token.X },
                    { Token.Empty, Token.Empty, Token.Empty },
                    { Token.Empty, Token.Empty, Token.Empty }
                };

                var player = new Player() { Position = Token.X };

                var winnerCalculator = new WinnerCalculator();
                var isWinner = winnerCalculator.CalculateIfWinner(player, currentBoard);

                Assert.True(isWinner);
            }

            [Test]
            public void GivenRow2_ReturnWinner()
            {
                var currentBoard = new Token[,]
                {
                    { Token.Empty, Token.Empty, Token.Empty },
                    {Token.X, Token.X, Token.X  },
                    { Token.Empty, Token.Empty, Token.Empty }
                };

                var player = new Player() { Position = Token.X };

                var winnerCalculator = new WinnerCalculator();
                var isWinner = winnerCalculator.IsRowWinner(player, currentBoard);

                Assert.True(isWinner);
            }
        }
    }
}
