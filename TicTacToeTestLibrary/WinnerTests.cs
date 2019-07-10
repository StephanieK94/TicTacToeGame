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
            public void GivenColumn_ReturnWinner()
            {
                var rowWinner = new Token[,] 
                { 
                    { Token.X, Token.Empty, Token.Empty }, 
                    { Token.X, Token.Empty, Token.Empty }, 
                    { Token.X, Token.Empty, Token.Empty }
                };

                var winnerCalculator = new WinnerCalculator();
                var isWinner = winnerCalculator.CalculateIfWinner(rowWinner);

                Assert.True(isWinner);
            }

            [Test]
            public void GivenRow_ReturnWinner()
            {
                var colWinner = new Token[,]
                {
                    { Token.X, Token.X, Token.X },
                    { Token.Empty, Token.Empty, Token.Empty },
                    { Token.Empty, Token.Empty, Token.Empty }
                };

                var winnerCalculator = new WinnerCalculator();
                var isWinner = winnerCalculator.CalculateIfWinner(colWinner);

                Assert.True(isWinner);
            }
        }
    }
}
