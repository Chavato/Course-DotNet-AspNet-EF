using System;


namespace BasicClasses
{
    class Triangle
    {
        //lateral sizes
        public Double SideA;
        public Double SideB;
        public Double SideC;

        public double Area()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

        }


    }


    class Squad
    {
        //lateral size
        public Double Side;
    }

    class Rectangle
    {
        //lateral sizes
        public Double Width;
        public Double Height;


        public Double Area()
        {
            return Width * Height;
        }
        public Double Perimeter()
        {
            return Width * 2 + Height * 2;
        }
        public Double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }
    }

    class Circle
    {

        double Raio;
        static double Pi = 3.14;
        double Diameter()
        {
            return Raio * 2 * Pi;
        }
    }
}