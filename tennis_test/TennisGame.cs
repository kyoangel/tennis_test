namespace tennis_test
{
    public class TennisGame
    {
        public string GetScore()
        {
            if (FirstPlayerScoreTimes == 1)
            {
                return "Fifteen Love";
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

        public int SecondPlayerScoreTimes { get; set; }

        public int FirstPlayerScoreTimes { get; set; }
    }
}