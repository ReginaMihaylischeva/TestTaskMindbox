using System;
using Xunit;
using TestTask;

namespace Tests
{
    public class CircleTest
    {
        [Fact]
        public void GetSquareTest()
        {
            var radius = 5;
            var circle = new �ircle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2);

            var square = circle.Square;

            Assert.Equal(square, expectedValue);
        }

        [Fact]
        public void ZeroRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new �ircle(0));
        }

        [Fact]
        public void NegativeRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new �ircle(-100));
        }

        [Fact]
        public void RightRadiusTest()
        {
            var radius = 5;
            var circle = new �ircle(radius);
            Assert.Equal(circle.GetRagius(), radius);
        }
    }
}
