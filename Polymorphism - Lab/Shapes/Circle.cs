﻿namespace Shapes
{
    using System;

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.radius;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}