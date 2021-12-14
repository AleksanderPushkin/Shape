using System;

namespace Shape
{
    public class Circle : Shape
    {
        private double Radius;

        public Circle(double Radius)
        {
            if (Radius < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше нуля");
            }

            this.Radius = Radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
