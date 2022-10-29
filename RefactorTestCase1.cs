using MoodAnalyserProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserTest
{
    [TestClass]
    public class RefactorTestCase1
    {
        private MoodAnalyserRefactor moodAnalyser;
        [TestMethod]
        public void RefactorMessageReturnsSad()
        {
            //Arrange
            string myMessage = "I am in Sad Mood";
            moodAnalyser = new MoodAnalyserRefactor(myMessage);

            //Act
            var result = moodAnalyser.analyseMood();

            //Assert
            Assert.AreEqual("SAD", result);
        }
    }
}
