using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tennis_test
{
    [TestClass]
    public class TennisGameTest
    {
        [TestMethod]
        public void love_all()
        {
            var tenisGame = new TennisGame();
            var score = tenisGame.GetScore();
            Assert.AreEqual("Love All", score);
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            var tenisGame = new TennisGame();
            tenisGame.FirstPlayerScore();

            var score = tenisGame.GetScore();
            Assert.AreEqual("Fifteen Love", score);
        }
    }
}