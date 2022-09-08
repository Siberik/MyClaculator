using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib2;
using System;

namespace SubCalcTests
{
    [TestClass]
    public class SubUnitTest
    {
        /// <summary>
        /// Нахождение результата вычитания простых чисел
        /// </summary>
        [TestMethod]
        public void Sub_10and5_5returned()
        {
            //arrange
            int x = 10, y = 5;
            int expected =5;

            //act
            MyCalcClass c = new MyCalcClass();
            int actual = c.Sub(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sub_minus10and5_minus5returned()
        {
            //arrange
            int x = -10, y = 5;
            int expected = -15;

            //act
            MyCalcClass c = new MyCalcClass();
            int actual = c.Sub(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
