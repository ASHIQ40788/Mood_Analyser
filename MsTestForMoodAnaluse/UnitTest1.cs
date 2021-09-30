using System;
using System.Reflection;
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
        /// UC-4 Create Default Constructor Using Reflection
        /// </summary>
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyser_Using_Reflection_Return_defaultConstructor()
        {
            MoodAnalyser excepted = new MoodAnalyser();
            object obj = null;
            try
            {
                //Act
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject("ReflectionDemo.MoodAnalyser", "MoodAnalyser");
            }
            catch (CustomMoodAnalyserException execption)
            {
                //Assert
                throw new Exception(execption.Message);
            }
            obj.Equals(excepted);

        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyser_Using_Reflection_Return_Exception()
        {
            string excepted = "constructor not found";
            object obj = null;
            try
            {
                //ACT
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject("Exception058.MoodAnalyser", "MoodAnal");
            }
            catch (CustomMoodAnalyserException execption)
            {
                //ASSERT
                Assert.AreEqual(excepted, execption.Message);
            }

        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyser_Using_Reflection_Return_ClassException()
        {
            string excepted = "class not found";
            object obj = null;
            try
            {
                //ACT
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserObject("Exception058.EmployeeWage", "EmployeeWage");
            }
            catch (CustomMoodAnalyserException execption)
            {
                //ASSERT
                Assert.AreEqual(excepted, execption.Message);
            }

        }

        /// <summary>
        ///  UC-5 -mood analyzer using reflection return parameterised constructor.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyser_Using_Reflection_Return_ParameterisedConstructor()
        {
            string message = "i am in a happy mood";
            MoodAnalyser excepted = new MoodAnalyser(message);
            object actual = null;
            try
            {
                //ACT
                MoodAnalyserFactory058 factory = new MoodAnalyserFactory058();
                actual = factory.CreateMoodAnalyserParameterisedObject("MoodAnalyser", "MoodAnalyser", message);
            }
            catch (CustomMoodAnalyserException execption)
            {
                //ASSERT
                throw new Exception(execption.Message);
            }


        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_Return_classException_ParametarisedConstructor()
        {
            string excepted = "class not found";
            string message = "i am in a happy mood";
            object actual = null;
            try
            {
                //ACT
                MoodAnalyserFactory058 factory = new MoodAnalyserFactory058();
                actual = factory.CreateMoodAnalyserParameterisedObject("EmpWage", "EmpWage", message);
            }
            catch (CustomMoodAnalyserException execption)
            {
                //ASSERT
                Assert.AreEqual(excepted, execption.Message);
            }


        }
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyser_Using_Reflection_Return_Constructor_Exception_ParameterisedConstructor()
        {
            string excepted = "constructor not found";
            string message = "I am in a happy mood";
            object actual = null;
            try
            {
                //ACT
                MoodAnalyserFactory058 factory = new MoodAnalyserFactory058();
                actual = factory.CreateMoodAnalyserParameterisedObject("MoodAnalyser", "Empwage", message);
            }
            catch (CustomMoodAnalyserException execption)
            {
                //ASSERT
                Assert.AreEqual(excepted, execption.Message);
            }



        }

    }



}


