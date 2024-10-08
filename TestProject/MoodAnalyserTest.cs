    using CSharp_Unit_Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace TestProject
    {
        [TestClass]
        public class MoodAnalyserTest
        {

            [TestMethod]
            [DataRow("Today I am Happy", "Mood is Happy")]
            [DataRow("I am feeling sad today", "Mood is Sad")]
            [DataRow("It's an ordinary day.", "Mood is Sad")]  // Assuming default "Sad" for non-happy messages
            [DataRow("I am so HAPPY today!", "Mood is Happy")]  // Case-insensitive "Happy"
            [DataRow("happy moments!", "Mood is Happy")]        // Lowercase "happy"
            [DataRow("I don't feel anything special", "Mood is Sad")]  // Neutral message
            public void ReturnHappyOrSad(string message, string expected)
            {
                // Arrange
                MoodAnalyser mood = new MoodAnalyser();

                // Act
                string actual = mood.AnalyseMood(message);

                // Assert
                Assert.AreEqual(expected, actual);
            }

        }
    }
