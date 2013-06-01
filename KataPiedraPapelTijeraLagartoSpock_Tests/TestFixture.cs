using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataPiedraPapelTijeraLagartoSpock_Tests
{
    [TestFixture]
    public class TestFixture1
    {
        [Test]
        public void Test_Empates()
        {
            Assert.AreEqual(Game.DRAW, Game.GetResult(Elements.Stone, Elements.Stone));
            Assert.AreEqual(Game.DRAW, Game.GetResult(Elements.Paper, Elements.Paper));
            Assert.AreEqual(Game.DRAW, Game.GetResult(Elements.Scissor, Elements.Scissor));
            Assert.AreEqual(Game.DRAW, Game.GetResult(Elements.Lizard, Elements.Lizard));
            Assert.AreEqual(Game.DRAW, Game.GetResult(Elements.Spock, Elements.Spock));
        }

        [Test]
        public void Test_Player1_WIN()
        {
            Assert.AreEqual(Game.PLAYER1_WIN, Game.GetResult(Elements.Stone, Elements.Lizard));
            Assert.AreEqual(Game.PLAYER1_WIN, Game.GetResult(Elements.Stone, Elements.Scissor));
            Assert.AreEqual(Game.PLAYER1_WIN, Game.GetResult(Elements.Paper, Elements.Stone));
            Assert.AreEqual(Game.PLAYER1_WIN, Game.GetResult(Elements.Paper, Elements.Spock));
            Assert.AreEqual(Game.PLAYER1_WIN, Game.GetResult(Elements.Scissor, Elements.Paper));
            Assert.AreEqual(Game.PLAYER1_WIN, Game.GetResult(Elements.Scissor, Elements.Lizard));
            Assert.AreEqual(Game.PLAYER1_WIN, Game.GetResult(Elements.Lizard, Elements.Spock));
            Assert.AreEqual(Game.PLAYER1_WIN, Game.GetResult(Elements.Lizard, Elements.Paper));
            Assert.AreEqual(Game.PLAYER1_WIN, Game.GetResult(Elements.Spock, Elements.Stone));
            Assert.AreEqual(Game.PLAYER1_WIN, Game.GetResult(Elements.Spock, Elements.Scissor));
        }

        [Test]
        public void Test_Player2_WIN()
        {
            Assert.AreEqual(Game.PLAYER2_WIN, Game.GetResult(Elements.Lizard, Elements.Stone));
            Assert.AreEqual(Game.PLAYER2_WIN, Game.GetResult(Elements.Scissor, Elements.Stone));
            Assert.AreEqual(Game.PLAYER2_WIN, Game.GetResult(Elements.Stone, Elements.Paper));
            Assert.AreEqual(Game.PLAYER2_WIN, Game.GetResult(Elements.Spock, Elements.Paper));
            Assert.AreEqual(Game.PLAYER2_WIN, Game.GetResult(Elements.Paper, Elements.Scissor));
            Assert.AreEqual(Game.PLAYER2_WIN, Game.GetResult(Elements.Lizard, Elements.Scissor));
            Assert.AreEqual(Game.PLAYER2_WIN, Game.GetResult(Elements.Spock, Elements.Lizard));
            Assert.AreEqual(Game.PLAYER2_WIN, Game.GetResult(Elements.Paper, Elements.Lizard));
            Assert.AreEqual(Game.PLAYER2_WIN, Game.GetResult(Elements.Stone, Elements.Spock));
            Assert.AreEqual(Game.PLAYER2_WIN, Game.GetResult(Elements.Scissor, Elements.Spock));
        }

        [Test]
        public void Test_JugadasAleatorias()
        {
            int numPlay = 25;
            for (int i = 0; i < numPlay; i++)
            {
                Elements p1 = Game.GetElementRandom();
                Elements p2 = Game.GetElementRandom();
                string result = Game.GetResult(p1, p2);
                Console.WriteLine("P1=" + p1.ToString().PadRight(7, ' ') + " - P2=" + p2.ToString().PadRight(7, ' ') + " => " + result);
            }
        }
    }
}
