using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser058Batch;

namespace MsTestForMoodAnalyse
{
    [TestClass]
    public class MsTestForMoodAnalyser
    {
        [TestMethod]
        [TestCategory("CustomException")]
        public void GivenNullShouldThrowCustomNullException()
        {
            ///AAA methodology

            ///Arrange
            string expected = "message show not be null";
            MoodAnalyser moodAnalyser = new MoodAnalyser("null");

            try
            {
                //Act
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        [TestCategory("CustomException")]
        public void GivenEmptyShouldThrowCustomEmptyException()
        {
            ///AAA methodology

            ///Arrange
            string expected = "message show not be empty";
            MoodAnalyser moodAnalyser = new MoodAnalyser(string.Empty);

            try
            {
                //Act
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (CustomMoodAnalyserException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }

    }
}

