using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp_Unit_Testing;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    [TestClass]
    public class EvenOrOddTest
    {

        [TestMethod]
        [DataRow(2,true)]
        [DataRow(15,false)]
        [DataRow(28,true)]
        [DataRow(65,false)]
        public void CheckEvenOrNot(int num, bool expected)
        {
            //Arrange
            EvenOrOdd even = new EvenOrOdd();

            //Act
            bool actual = even.Even(num);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [DataRow(2, false)]
        [DataRow(15, true)]
        [DataRow(28, false)]
        [DataRow(65, true)]
        public void CheckOddOrNot(int num, bool expected)
        {
            //Arrange
            EvenOrOdd even = new EvenOrOdd();

            //Act
            bool actual = even.Odd(num);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
