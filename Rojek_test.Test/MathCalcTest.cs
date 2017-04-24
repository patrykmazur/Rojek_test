using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rojek_test.Test
{
    [TestClass]
    public class MathCalcTest
    {
        [TestMethod]
        public void AddTest()
        {
            //arrange
            MathCalc calc = new MathCalc();

            //act
            var result = calc.Add(5, 5);

            //assert
            Assert.AreEqual(10,result);
        }
    }
}
