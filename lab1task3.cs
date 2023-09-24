using System;

namespace lab1task3
{
    public class Point
    {
        private double x, y;
        public Point(double x, double y) 
        {
            this.x = x; this.y = y;
        }
        public double X
        { 
            get { return x; }
        }
        public double Y 
        { 
            get { return y; }    
        }
    }
    public class Figure
    {
        private Point[] points;
       
        public string Name
        {
            get;
            set;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5, null };
        }
        public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3, p4, null) { }
        public Figure(Point p1, Point p2, Point p3) : this(p1, p2, p3, null, null) { }
        public double LengthSide(Point A, Point B)
        {
            double a = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            Console.WriteLine("\n" + a);
            return a;
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                if (points[i] != null)
                {
                    if (points[i + 1] == null) { perimeter += LengthSide(points[0], points[i]); break; }
                    else { perimeter += LengthSide(points[i], points[i + 1]); }
                }
            }
            return perimeter;
        }
    }
    class task3
    {
        static void Main()
        {
            Point A = new Point(0, 0);
            Point B = new Point(0, 6);
            Point C = new Point(6, 6);
            Point D = new Point(6, 0);
            Point E = new Point(3, -4);
            Figure Square = new Figure(A, B, C, D) { Name = "Tolya" };
            Figure Pentagon = new Figure(A, B, C, D, E) { Name = "Sergey" };
            Console.WriteLine("\nПериметр фигуры " + Square.Name + " равен " + Square.PerimeterCalculator());
            Console.WriteLine("\nПериметр фигуры " + Pentagon.Name + " равен " + Pentagon.PerimeterCalculator());
        }
    }
}
