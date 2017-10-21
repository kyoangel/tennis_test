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
                {1,"Fifteen" },
                {2,"Thirty" },
                {3,"Forty" }
            };
            if (FirstPlayerScoreTimes > 0)
            {
                return dictionary[FirstPlayerScoreTimes] + " Love";
            }
            if (SecondPlayerScoreTimes == 1)
            {
                return "Love Fifteen";
            }
            if (SecondPlayerScoreTimes == 2)
            {
                return "Love Thirty";
            }
            return "Love All";
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