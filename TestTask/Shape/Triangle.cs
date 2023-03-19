using System;

namespace TestTask
{
    public sealed class Triangle : Shape.Shape
    {
        private double Side1 = 0;
        private double Side2 = 0;
        private double Side3 = 0;

        public Triangle(double side1, double side2, double side3)
        {
            SetSides(side1, side2, side3);
            Validate();
        }

        protected override double GetArea()
        {
            var halfP = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(
                halfP
                * (halfP - Side1)
                * (halfP - Side2)
                * (halfP - Side3)
            );
        }

        void SetSides(double side1, double side2, double side3)
        {
            if (side1 <= 0)
            {
                throw new ArgumentException("Неверно указана сторона.", nameof(side1));
            }

            if (side2 <= 0)
            {
                throw new ArgumentException("Неверно указана сторона.", nameof(side2));
            }

            if (side3 <= 0)
            {
                throw new ArgumentException("Неверно указана сторона.", nameof(side3));
            }           

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        protected override void Validate()
        {
            var isRectangular = IsRectangular(Side1, Side2, Side3);

            if (isRectangular)
            {
                return;
            }

            var isEquilateral = IsEquilateral(Side1, Side2, Side3);

            if (isEquilateral)
            {
                return;
            }

            var isPossible = IsPossible(Side1, Side2, Side3);

            if (isPossible)
            {
                return;
            }

            throw new ArgumentException("Из заданных сторон нельзя составить треугольник.");

        }

        public bool IsRectangular(double side1, double side2, double side3)
        {
            var maxSide = Math.Max(side1, Math.Max(side2, side3));
            var minSide = Math.Min(side1, Math.Min(side2, side3));
            var perimeter = side1 + side2 + side3;

            var middleSide = perimeter - minSide - maxSide;

            return Math.Pow(maxSide, 2) == Math.Pow(minSide, 2) + Math.Pow(middleSide, 2);
        }

        private bool IsEquilateral(double side1, double side2, double side3)
        {

            return (side1 == side2 && side1 == side3);
        }

        private bool IsPossible(double side1, double side2, double side3)
        {
            var maxSide = Math.Max(side1, Math.Max(side2, side3));
            var minSide = Math.Min(side1, Math.Min(side2, side3));
            var perimeter = side1 + side2 + side3;

            var middleSide = perimeter - minSide - maxSide;

            return maxSide < (minSide + middleSide) && minSide < (maxSide + middleSide) && middleSide < (maxSide + minSide);
        }

        public double GetSide1()
        {
            return Side1;
        }

        public double GetSide2()
        {
            return Side2;
        }

        public double GetSide3()
        {
            return Side3;
        }
    }
}
