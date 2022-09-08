using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib2;
using System;

namespace MulCalcTests
{
    [TestClass]
    public class MulUnitTest
    {
        /// <summary>
        /// Нахождение результата умножения простых чисел
        /// </summary>
        [TestMethod]
        public void Mul_3and10_30returned()
        {
            //arrange
            int x = 3, y = 10;
            int expected = 30;

            //act
            MyCalcClass c = new MyCalcClass();
            int actual = c.Mul(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Mul_minus3and10_30returned()
        {
            //arrange
            int x = -3, y = 10;
            int expected = -30;

            //act
            MyCalcClass c = new MyCalcClass();
            int actual = c.Mul(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
