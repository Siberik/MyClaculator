using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib2;
using System;

namespace DivCalcTests
{
    [TestClass]
    public class DivUnitTest
    {
        /// <summary>
        /// Деление на ноль
        /// </summary>
        [TestMethod]
        public void Div_3and0_ExceptionThrown()
        {
            double x = 3, y = 0; 

            MyCalcClass c= new MyCalcClass();

            Assert.ThrowsException<DivideByZeroException>(() => c.Div(x, y));
        }
    }
}
