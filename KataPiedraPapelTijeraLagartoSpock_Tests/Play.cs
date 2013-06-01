using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataPiedraPapelTijeraLagartoSpock_Tests
{
    public class Play
    {
        public Elements P1;
        public Elements P2;

        /// <summary>
        /// Lista de jugadas: Primer elemento gana al segundo elemento.
        /// </summary>
        private static List<Play> _listWinPlay = new List<Play>() { 
                new Play(Elements.Stone, Elements.Scissor),
                new Play(Elements.Stone, Elements.Lizard),
                new Play(Elements.Paper, Elements.Stone),
                new Play(Elements.Paper, Elements.Spock),
                new Play(Elements.Scissor, Elements.Paper),
                new Play(Elements.Scissor, Elements.Lizard),
                new Play(Elements.Lizard, Elements.Spock),
                new Play(Elements.Lizard, Elements.Paper),
                new Play(Elements.Spock, Elements.Stone),
                new Play(Elements.Spock, Elements.Scissor)
             };

        public Play(Elements p1, Elements p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public static bool IsDraw(Elements p1, Elements p2)
        {
            return (p1 == p2);
        }

        public static bool IsPlayer1Win(Elements p1, Elements p2)
        {
            bool result = false;
            foreach (Play play in _listWinPlay)
            {
                if ((play.P1 == p1) && (play.P2 == p2))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
