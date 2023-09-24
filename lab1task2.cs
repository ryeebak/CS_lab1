using System;

namespace lab1task2
{
    public class Rectangle
    {
        private double side1, side2;
        public Rectangle(double sideA, double sideB)
        {
            side1 = sideA; side2 = sideB;
        }
        private double CalculateArea()
        {
            return side1 * side2;
        }
        private double CalculatePerimeter()
        {
            return (side1 + side2) * 2;
        }
        public double Area
        {
            get { return CalculateArea(); }
        }
        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }

    }
    class Task2
    {
        static void Main()
        {
            Console.WriteLine("Введите значения сторон прямоугольника:\nсторона 1:");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("сторона 2:");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Rectangle A = new Rectangle(sideA, sideB);
            Console.WriteLine("площадь = " + A.Area + "\nпериметр = " + A.Perimeter);
        }
    }
}
