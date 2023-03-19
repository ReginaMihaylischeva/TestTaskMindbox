using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Shape
{
    public abstract class Shape
    {
        private readonly Lazy<double> square;

        public double Square => square.Value;

        protected Shape()
        {
            square = new Lazy<double>(GetArea);
        }

        protected abstract void Validate();

        protected abstract double GetArea();
    }
}
