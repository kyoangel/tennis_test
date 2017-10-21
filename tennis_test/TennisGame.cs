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
                {2,"Thirty" }
            };
            if (FirstPlayerScoreTimes > 0)
            {
                return dictionary[FirstPlayerScoreTimes] + " Love";
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