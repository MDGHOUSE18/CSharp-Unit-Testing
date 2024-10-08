using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Unit_Testing;
using System;
using System.Collections.Generic;
using System.Text;
using C__Unit_Testing;

namespace TestProject
{


    [TestClass]
    public class PalindromeCheckerTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataRow(1, "madam", true)]
        [DataRow(2, "hello", false)]
        [DataRow(3, "A", true)]
        [DataRow(4, "RaceCar", true)]
        [DataRow(5, "A man a plan a canal Panama", true)]
        [DataRow(6,"Ghouse",false)]
        public void CheckPalindromeOrNot(int testCase,string input,bool expected)
        {

            //Arrange
            Palindrome_Checker checker = new Palindrome_Checker();

            //Act
            bool res = checker.CheckingPolindrome(input);

            //Assert
            Assert.AreEqual(expected,res);

            // Output the result
            //if (res == expected)
            //{
            //    TestContext.WriteLine($"Testcase {testCaseNumber}: Passed");
            //}
            //else
            //{
            //    TestContext.WriteLine($"Testcase {testCaseNumber}: Failed");
            //}
            Console.WriteLine($"Testcase {testCase}: {(res == expected ? "Passed" : "Failed")}");


        }

    }
}
