using System;
using System.Collections.Generic;

namespace tennis_test
{
    public class TennisGame
    {
        public int FirstPlayerScoreTimes { get; set; }
        public int SecondPlayerScoreTimes { get; set; }

        public string GetScore()
        {
            var dictionary = new Dictionary<int, string>()
            {
                {0,"Love" },
                {1,"Fifteen" },
                {2,"Thirty" },
                {3,"Forty" }
            };
            if (FirstPlayerScoreTimes != SecondPlayerScoreTimes)
            {
                if (FirstPlayerScoreTimes > 3 || SecondPlayerScoreTimes > 3)
                {
                    if (IsAdv())
                    {
                        AdvPlayer = GetAdvPlayer();
                        return AdvPlayer + " Adv";
                    }
                    return GetAdvPlayer() + " Win";
                }
                return dictionary[FirstPlayerScoreTimes] + " " + dictionary[SecondPlayerScoreTimes];
            }

            if (FirstPlayerScoreTimes > 3)
            {
                return "Deuce";
            }
            return dictionary[FirstPlayerScoreTimes] + " All";
        }

        private bool IsAdv()
        {
            return Math.Abs(FirstPlayerScoreTimes - SecondPlayerScoreTimes) == 1;
        }

        private string GetAdvPlayer()
        {
            return FirstPlayerScoreTimes > SecondPlayerScoreTimes ? FirstPlayer : SecondPlayer;
        }

        public string AdvPlayer { get; set; }

        public string FirstPlayer { get; set; }
        public string SecondPlayer { get; set; }

        public void FirstPlayerScore()
        {
            FirstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            SecondPlayerScoreTimes++;
        }
    }
}