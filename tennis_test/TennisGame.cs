namespace tennis_test
{
    public class TennisGame
    {
        public int FirstPlayerScoreTimes { get; set; }
        public int SecondPlayerScoreTimes { get; set; }

        public string GetScore()
        {
            if (FirstPlayerScoreTimes == 1)
            {
                return "Fifteen Love";
            }
            if (FirstPlayerScoreTimes == 2)
            {
                return "Thirty Love";
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