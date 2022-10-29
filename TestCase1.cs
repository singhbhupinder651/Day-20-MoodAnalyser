using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class TestCase1
    {
        private MoodAnalyser moodAnalyser;
        [TestMethod]
        public void MessageReturnsSad()
        {
            //Arrange
            moodAnalyser = new MoodAnalyser();
            string myMood = "I am in Sad Mood";

            //Act
            var result = moodAnalyser.analyseMood(myMood);

            //Assert
            Assert.AreEqual("SAD", result);

        }


    }
}