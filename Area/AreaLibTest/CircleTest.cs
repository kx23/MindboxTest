using AreaLib;
using System;
using Xunit;

namespace AreaTest
{
    public class CircleTest
    {
        [Fact]
        public void CircleConstructorRadiusLengthTest()
        {
            Action a;
            ArgumentException e;

            // Arrage
            a = () => new Circle(-7);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("Radius is not greater than 0.", e.Message);

            // Arrage
            a = () => new Circle(0);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("Radius is not greater than 0.", e.Message);

        }


        [Fact]
        public void CircleAreaTest()
        {

            Circle t;

            // Arrage/Act
            t = new Circle(3);

            // Assert
            Assert.Equal(MathF.PI * 3 * 3, t.Area);

            // Arrage/Act
            t = new Circle(5);

            // Assert
            Assert.Equal(MathF.PI * 5 * 5, t.Area);

        }

    }
}