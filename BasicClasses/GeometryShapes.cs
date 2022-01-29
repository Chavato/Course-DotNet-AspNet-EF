using System;


namespace BasicClasses
{
    class Triangle
    {
        //lateral sizes
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

        }


    }


    public class Squad
    {
        public double Side { get; set; }

        public Squad(double side)
        {
            Side = side;
        }

        public double Area()
        {
            return Side * Side;
        }

    }

    public class Rectangle
    {
        //lateral sizes
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Area()
        {
            return Width * Height;
        }
        public double Perimeter()
        {
            return Width * 2 + Height * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }
    }

    public class Circle
    {

        public double Radius { get; set; }
        private static double Pi = 3.14;

        public Circle(double radius)
        {
            Radius = radius;
        }
        double Diameter()
        {
            return Radius * 2 * Pi;
        }
    }
}