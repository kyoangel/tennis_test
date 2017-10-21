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
                return dictionary[FirstPlayerScoreTimes] + " " + dictionary[SecondPlayerScoreTimes];
            }

            if (FirstPlayerScoreTimes > 3)
            {
                return "Deuce";
            }
            return dictionary[FirstPlayerScoreTimes] + " All";
        }

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