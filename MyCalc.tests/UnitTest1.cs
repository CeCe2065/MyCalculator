using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalc.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            int x = 2;
            int y = 3;
            int expected = 5;
            int actual = MyCalculator.Calculator.Add(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideTest()
        {
            int x = 10;
            int y = 2;
            int expected = 5;
            int actual = MyCalculator.Calculator.Divide(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplyTest()
        {
            int x = 4;
            int y = 6;
            int expected = 24;
            int actual = MyCalculator.Calculator.Multiply(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractTest()
        {
            int x = 11;
            int y = 4;
            int expected = 7;
            int actual = MyCalculator.Calculator.Subtract(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
