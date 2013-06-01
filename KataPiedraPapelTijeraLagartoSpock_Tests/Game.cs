using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace KataPiedraPapelTijeraLagartoSpock_Tests
{
    public class Game
    {
        public readonly static string DRAW = "-DRAW-";
        public readonly static string PLAYER1_WIN = "PLAYER 1 WIN";
        public readonly static string PLAYER2_WIN = "PLAYER 2 WIN";

        public static string GetResult(Elements player1, Elements player2)
        {
            string result = "";
            
            if (Play.IsDraw(player1, player2))
                result = DRAW;
            else if(Play.IsPlayer1Win(player1, player2))
                result = PLAYER1_WIN;
            else
                result = PLAYER2_WIN;

            return result;
        }

        public static Elements GetElementRandom()
        {
            int sec = DateTime.Now.Second;
            int den = (sec%3) == 0 ? sec : (sec%3);
            Thread.Sleep(DateTime.Now.Millisecond / den); // 75 porque no?

            int seed = int.Parse(DateTime.Now.Millisecond.ToString());
            int randomNumber = new Random(seed).Next(1, Enum.GetNames(typeof(Elements)).Length);
            return ((Elements)Enum.GetValues(typeof(Elements)).GetValue(randomNumber));
        }
    }
}