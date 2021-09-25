using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser058Batch;

namespace MsTestForMoodAnalyse
{

    /// <summary>
    /// UC-1 Analzing user mood based on happy or sad word.
    /// </summary>
    [TestClass]
    public class MsTestForMoodAnalyser
    {
        [TestMethod]
        [TestCategory("HappyGroup")]
        public void GivenHapppyShouldReturnHappy()
        {
            ///AAA methodology

            ///Arrange
            string expected = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I AM IN HAPPY MOOD ");

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [TestCategory("Sad Group")]
        public void GivenSadShouldReturnSad()
        {
            ///AAA methodology

            ///Arrange
            string expected = "sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I AM IN sad MOOD ");

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}


        
