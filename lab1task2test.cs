using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace lab1task2.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void CalculateArea_is_correct()
        {
            // arrange
            double sideA = 10;
            double sideB = 20;
            double expected = 200;

            // act
            lab1task2.Rectangle rectangle = new lab1task2.Rectangle(sideA, sideB);
            double area = rectangle.Area;

            // assert
            Assert.AreEqual(expected, area);

        }
        [TestMethod]
        public void CalculatePerimeter_is_correct()
        {
            // arrange
            double sideA = 30;
            double sideB = 40;
            double expected = 140;

            // act
            lab1task2.Rectangle rectangle = new lab1task2.Rectangle(sideA, sideB);
            double perimeter = rectangle.Perimeter;

            // assert
            Assert.AreEqual(expected, perimeter);
        }
    }
}
