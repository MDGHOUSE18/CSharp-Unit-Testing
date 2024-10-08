using C__Unit_Testing;
using NUnit.Framework;
using System.Drawing;

namespace NunitTest
{
    [TestFixture]
    public class Tests
    {
        private VowelCount count;
        [SetUp]
        public void Setup()
        {
            //Arrange
            count = new VowelCount();
        }

        [Test]
        [TestCase("ghouse",3)]
        [TestCase("mdjs",0)]
        [TestCase("MahammedAli",5)]
        [TestCase("AEIOU",5)]
        public void Test1(string str, int expected)
        {
            //Act
            int actual = count.CountVowels(str);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

            TestContext.WriteLine($"Test Case Passed for input '{str}' with expected result {expected}");
        }
    }
}