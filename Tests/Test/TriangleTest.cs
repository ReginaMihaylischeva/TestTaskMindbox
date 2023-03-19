using System;
using Xunit;
using TestTask;

namespace Tests
{
    public class TriangleTest
    {
        [Fact]
        public void GetSquareTest()
        {
            var side1 = 7;
            var side2 = 4;
            var side3 = 10;
            var triangle = new Triangle(side1, side2, side3);
            var halfP = (side1 + side2 + side3) / 2d;

            var expectedValue = Math.Sqrt(
                halfP
                * (halfP - side1)
                * (halfP - side2)
                * (halfP - side3));

            var square = triangle.Square;

            Assert.Equal(square, expectedValue);
        }

        [Fact]
        public void ZeroSidesTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
        }

        [Fact]
        public void NegativeSidesTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-100, -100, -100));
        }

        [Fact]
        public void EquilateralTest()
        {
            var side1 = 3;
            var side2 = 3;
            var side3 = 3;
            var triangle = new Triangle(side1, side2, side3);

            var halfP = (side1 + side2 + side3) / 2d;

            double expectedValue = Math.Sqrt(
                halfP
                * (halfP - side1)
                * (halfP - side2)
                * (halfP - side3));

            Assert.Equal(triangle.Square, expectedValue);
        }

        [Fact]
        public void RectangularTest()
        {
            var side1 = 3;
            var side2 = 4;
            var side3 = 5;
            var triangle = new Triangle(side1, side2, side3);

            var halfP = (side1 + side2 + side3) / 2;

            var expectedValue = Math.Sqrt(
                halfP
                * (halfP - side1)
                * (halfP - side2)
                * (halfP - side3));

            Assert.Equal(triangle.Square, expectedValue);

        }
    }
}
