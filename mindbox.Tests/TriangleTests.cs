using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CheckRightTriangleTests_3and4and5_return_True()
        {
            //arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            bool expected = true;

            //act
            bool actual = Triangle.CheckRightTriangle(side1, side2, side3);

            //asert
            Assert.AreEqual(expected, actual);
        }
    }
}
