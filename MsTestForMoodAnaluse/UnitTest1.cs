using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser058Batch;

namespace MsTestForMoodAnalyse
{
    
    [TestClass]
    public class MsTestForMoodAnalyser
    {
        MoodAnalyserFactory factory = null;
        [TestInitialize]
        public void Setup()
        {
           factory = new MoodAnalyserFactory();

        }
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

        [TestMethod]
        [TestCategory("NegativeScenario")]
        public void GivenMessageShouldReturnElseCondition()
        {
            ///AAA methodology

            ///Arrange
            string expected = "there is no happy or sad exist in the given message";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I AM IN MOOD ");

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [TestCategory("NegativeScenario")]
        public void GivenNullShouldReturnHappy()
        {
            ///AAA methodology

            ///Arrange
            string expected = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("null");

            //Act
            string actual = moodAnalyser.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);
        }



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


        /// <summary>
        /// TC4- Create default constructor using reflection
        /// </summary>

        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyser_Using_Reflection_Return_defaultConstructor()
        {
            MoodAnalyser expected = new MoodAnalyser();
            object obj = null;
            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                //Act
                obj = factory.CreateMoodAnalyserObject("MoodAnalyserForTvsBatch.MoodAnalyser", "MoodAnalyser");

            }
            catch (CustomMoodAnalyserException exception)
            {
                //Assert
                throw new Exception(exception.Message);

            }
            obj.Equals(expected);
        }

       

    }

}
