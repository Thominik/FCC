namespace FCCApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectScores_ShouldCorrectResult()
        {
            var user = new User("Dominik", "asdasd123");
            user.AddScore(5);
            user.AddScore(5);
            user.AddScore(-1);

            var result = user.Result;

            Assert.AreEqual(9, result);
        }

        [Test]
        public void WhenUserCollectMoreNegativeScores_ShouldCorrectResult()
        {
            var user = new User("Adam", "asdasd");
            user.AddScore(5);
            user.RemoveScore(-1);
            user.AddScore(5);
            user.RemoveScore(-10);

            var result = user.Result;

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void WhenUserCollectScoresWithoutMinusSign_ShouldCorrectResult()
        {
            var user = new User("Bartek", "qwe123");
            user.AddScore(5);
            user.AddScore(5);
            user.RemoveScoreWithoutMinusSign(10);

            var result = user.Result;

            Assert.AreEqual(0, result);
        }
    }
}