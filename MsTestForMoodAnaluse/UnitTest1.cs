using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser058Batch;

namespace MsTestForMoodAnalyse
{

    /// <summary>
    /// UC-2 Analyzing Null Exception Returning Happy Mood.
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


        
