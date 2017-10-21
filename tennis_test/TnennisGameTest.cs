using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tennis_test
{
    [TestClass]
    public class TennisGameTest
    {
        [TestMethod]
        public void love_all()
        {
            var tennisGame = new TennisGame();
            var score = tennisGame.GetScore();
            Assert.AreEqual("Love All", score);
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            var tennisGame = new TennisGame();
            tennisGame.FirstPlayerScore();

            var score = tennisGame.GetScore();
            Assert.AreEqual("Fifteen Love", score);
        }

        [TestMethod]
        public void Thirty_Love()
        {
            var tennisGame = new TennisGame();
            GivenFirstPlayerScoreTimes(tennisGame, 2);
            var score = tennisGame.GetScore();
            Assert.AreEqual("Thirty Love", score);
        }

        [TestMethod]
        public void Forty_Love()
        {
            var tennisGame = new TennisGame();
            GivenFirstPlayerScoreTimes(tennisGame, 3);
            var score = tennisGame.GetScore();
            Assert.AreEqual("Forty Love", score);
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            var tennisGame = new TennisGame();
            tennisGame.SecondPlayerScore();
            var score = tennisGame.GetScore();
            Assert.AreEqual("Love Fifteen", score);
        }

        [TestMethod]
        public void Love_Thirty()
        {
            var tennisGame = new TennisGame();
            GivenSecondPlayerScoreTimes(tennisGame, 2);
            var score = tennisGame.GetScore();
            Assert.AreEqual("Love Thirty", score);
        }

        [TestMethod]
        public void Love_Forty()
        {
            var tennisGame = new TennisGame();
            GivenSecondPlayerScoreTimes(tennisGame, 3);
            var score = tennisGame.GetScore();
            Assert.AreEqual("Love Forty", score);
        }

        [TestMethod]
        public void Fifteen_All()
        {
            var tennisGame = new TennisGame();
            GivenFirstPlayerScoreTimes(tennisGame, 1);
            GivenSecondPlayerScoreTimes(tennisGame, 1);
            var score = tennisGame.GetScore();
            Assert.AreEqual("Fifteen All", score);
        }

        [TestMethod]
        public void Thirty_All()
        {
            var tennisGame = new TennisGame();
            GivenFirstPlayerScoreTimes(tennisGame, 2);
            GivenSecondPlayerScoreTimes(tennisGame, 2);
            var score = tennisGame.GetScore();
            Assert.AreEqual("Thirty All", score);
        }

        [TestMethod]
        public void Deuce()
        {
            var tennisGame = new TennisGame();
            GivenFirstPlayerScoreTimes(tennisGame, 4);
            GivenSecondPlayerScoreTimes(tennisGame, 4);
            var score = tennisGame.GetScore();
            Assert.AreEqual("Deuce", score);
        }

        private static void GivenSecondPlayerScoreTimes(TennisGame tennisGame, int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.SecondPlayerScore();
            }
        }

        private static void GivenFirstPlayerScoreTimes(TennisGame tennisGame, int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.FirstPlayerScore();
            }
        }
    }
}