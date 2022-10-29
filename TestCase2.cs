using MoodAnalyserProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserTest
{
    [TestClass]
    public class TestCase2
    {
        private MoodAnalyser moodAnalyser;
        [TestMethod]
        public void MessageReturnsHappy()
        {
            //Arrange
            moodAnalyser = new MoodAnalyser();
            string myMood = "I am in Any Mood";

            //Act
            var result = moodAnalyser.analyseMood(myMood);

            //Assert
            Assert.AreEqual("HAPPY", result);
        }

    }
}
