using System;

namespace Shape
{
    public class Triangle : Shape
    {
        private double SideA;

        private double SideB;

        private double SideC;


        public Triangle(double SideA, double SideB, double SideC)
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new ArgumentException("Значение не может быть меньше нуля");
            }
            if (!DefineATriangle(SideA, SideB, SideC))
            {
                throw new Exception("Это не треугольник");
            }

            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }
        public override double Area()
        {

            var p = (SideA + SideB + SideC) / 2;

            var S = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

            return S;

        }


        private bool DefineATriangle(double A, double B, double C)
        {
            return (A + B > C) && (B + C > A) && (A + C > B);
        }
        public bool IsRightTriangle(double A, double B, double C)
        {
            return (A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A);
        }
    }
}

