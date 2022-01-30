using Entities.Enums.class136;
using System;

namespace Entities.class136
{
    class Circle : Shape
    {

        public double Radius { get; set; }


        public Circle(double radius, Color color)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }


    }
}