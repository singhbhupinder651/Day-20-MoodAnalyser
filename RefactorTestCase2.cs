using MoodAnalyserProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserTest
{
    [TestClass]
    public class RefactorTestCase2
    {
        private MoodAnalyserRefactor moodAnalyser;
        [TestMethod]
        public void RefactorMessageReturnsHappy()
        {
            //Arrange
            string myMessage = "I am in Happy Mood";
            moodAnalyser = new MoodAnalyserRefactor(myMessage);

            //Act
            var result = moodAnalyser.analyseMood();

            //Assert
            Assert.AreEqual("HAPPY", result);
        }
    }
}
