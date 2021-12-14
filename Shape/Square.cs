using System;

namespace Shape
{
    public class Square : Shape
    {
        private double _side;
        public Square(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Значение не может быть меньше нуля");
            }
            _side = side;
        }

        public override double Area()
        {
            return _side * _side;
        }
    }
}
