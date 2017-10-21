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
            return IsPlayerScoreDifferent()
                ? (IsPlayerReadyToWin()
                    ? GetAdvScore()
                    : GetNormalScore(dictionary))
                : (IsDueuce() ? Deuce() : GetTheSameScore(dictionary));
        }

        private bool IsPlayerScoreDifferent()
        {
            return FirstPlayerScoreTimes != SecondPlayerScoreTimes;
        }

        private string GetTheSameScore(Dictionary<int, string> dictionary)
        {
            return dictionary[FirstPlayerScoreTimes] + " All";
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDueuce()
        {
            return FirstPlayerScoreTimes > 3;
        }

        private bool IsPlayerReadyToWin()
        {
            return FirstPlayerScoreTimes > 3 || SecondPlayerScoreTimes > 3;
        }

        private string GetAdvScore()
        {
            return GetAdvPlayer() + (IsAdv() ? " Adv" : " Win");
        }

        private string GetNormalScore(Dictionary<int, string> dictionary)
        {
            return dictionary[FirstPlayerScoreTimes] + " " + dictionary[SecondPlayerScoreTimes];
        }

        private bool IsAdv()
        {
            return Math.Abs(FirstPlayerScoreTimes - SecondPlayerScoreTimes) == 1;
        }

        private string GetAdvPlayer()
        {
            return FirstPlayerScoreTimes > SecondPlayerScoreTimes ? FirstPlayer : SecondPlayer;
        }

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