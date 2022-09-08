using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib2;
using System;

namespace MyCalcLibTests
{
    [TestClass]
    public class MyCalcLibUnitTest
    {
        /// <summary>
        /// Нахождение простых слагаемых
        /// </summary>
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange
            int x=10, y=20;
            int expected = 30;

            //act
             MyCalcClass c = new MyCalcClass();
            int actual=c.Sum(x,y);
            //assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Нахождение суммы с одним слагаемым в виде нуля
        /// </summary>
        [TestMethod]
        public void Sum_0and10_10returned()
        {
            //arrange
            int x = 0, y = 10;
            int expected = 10;

            //act
            MyCalcClass c = new MyCalcClass();
            int actual = c.Sum(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
