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
            tennisGame.FirstPlayerScore();

            tennisGame.FirstPlayerScore();
            var score = tennisGame.GetScore();
            Assert.AreEqual("Thirty Love", score);
        }
    }
}