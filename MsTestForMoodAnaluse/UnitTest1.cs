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
        [TestCategory("NegativeScenario")]
        public void GivenNullShouldReturnHappy()

        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);

            //ACT
            string actual = moodAnalyser.AnalyseMood();

            //ASSERT
            Assert.AreEqual(excepted, actual);
        }
    
    }
}


        