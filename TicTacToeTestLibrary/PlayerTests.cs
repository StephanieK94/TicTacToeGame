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
    public class PlayerTests
    {
        private GameOperations operations = new GameOperations();
        private Player player = new Player();
        
        [Test]
        public void GivenPlayerX_WhenNextTurn_ReturnPlayerO()
        {
            player.Token = 'X';

            player.Token = operations.ChangePlayer(player);

            Assert.AreEqual('O', player.Token);
        }

        [Test]
        public void GivenPlayerO_WhenChangesTurn_ReturnPlayerX()
        {
            player.Token = '0';

            player.Token = operations.ChangePlayer(player);

            Assert.AreEqual('X', player.Token);
        }

        [Test]
        public void GivenPlayerSymbol_WhenPrintingValidMove_PrintsPlayerNumber()
        {
        }
    }
}
