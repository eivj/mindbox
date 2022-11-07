using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace mindbox.Tests
{
    [TestClass]
    public class ShapeAreaTests
    {
        [TestMethod]
        public void CalcuteAreaOfShape_3_return_PI_multiply_By_3_Squared()
        {
            //arrange
            double radius = 3;
            double expected = 28.274333882308138;

            //act
            double actual = ShapeArea.CalcuteAreaOfShape(radius);

            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcuteAreaOfShape_3and4and5_return6()
        {
            //arange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expected = 6;

            //act 
            double actual = ShapeArea.CalcuteAreaOfShape(side1, side2, side3);

            //asert
            Assert.AreEqual(expected, actual);

        }
    }
}
