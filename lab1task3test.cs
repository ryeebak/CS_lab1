using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lab1task3.Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void Is_Point_constructor_correct()
        {
            int x = 1;
            int y = 2;
            lab1task3.Point point = new lab1task3.Point(x, y);
            Assert.AreEqual(x, point.X);
            Assert.AreEqual(y, point.Y);
        }
    }
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void Is_LengthSide_method_correct()
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 6);
            Point C = new Point(6, 6);
            Point D = new Point(6, 0);
            Point E = new Point(3, -4);
            lab1task3.Figure figure = new lab1task3.Figure(A, B, C, D, E);
            double expected = 5;

            double length = figure.LengthSide(D, E);

            Assert.AreEqual(expected, length);
        }
        [TestMethod]
        public void Is_Perimeter_function_correct()
        {
            lab1task3.Point A = new lab1task3.Point(0, 0);
            lab1task3.Point B = new lab1task3.Point(0, 4);
            lab1task3.Point C = new lab1task3.Point(3, 0);
            lab1task3.Point D = new lab1task3.Point(0, -4);
            lab1task3.Figure figure = new lab1task3.Figure(A, B, C, D);
            double expected = 18;

            Assert.AreEqual(expected, figure.PerimeterCalculator());
        }
        [TestMethod]
        public void Is_Perimeter_function_with_unnecessary_points_correct()
        {
            lab1task3.Point A = new lab1task3.Point(0, 0);
            lab1task3.Point B = new lab1task3.Point(0, 4);
            lab1task3.Point C = new lab1task3.Point(3, 0);
            lab1task3.Point D = new lab1task3.Point(0, -4);
            lab1task3.Figure figure = new lab1task3.Figure(A, B, C);
            double expected = 12;

            Assert.AreEqual(expected, figure.PerimeterCalculator());
        }
        [TestMethod]
        public void Is_Naming_correct()
        {
            lab1task3.Point A = new lab1task3.Point(0, 0);
            lab1task3.Point B = new lab1task3.Point(0, 4);
            lab1task3.Point C = new lab1task3.Point(3, 0);
            lab1task3.Figure figure = new lab1task3.Figure(A, B, C) { Name = "Tolya" };
            string expected = "Tolya";

            Assert.AreEqual(expected, "Tolya");
        }
    }
}
