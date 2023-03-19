using System;

namespace TestTask
{
    public sealed class Сircle : Shape.Shape
    {
        private double Radius = 0;

        protected override double GetArea()
        {

            return Math.PI * Math.Pow(Radius, 2);
        }

        void SetRadius(double radius)
        {         
            Radius = radius;
            Validate();
        }

        public double GetRagius()
        {
            return Radius;
        }

        public Сircle(double radius)
        {
            SetRadius(radius);
        }

        protected override void Validate()
        {
            if (Radius <= 0)
            {
                throw new ArgumentException("Передан некорректный радиус.", nameof(Radius));
            }
        }
    }
}
