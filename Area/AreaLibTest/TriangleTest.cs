using AreaLib;
using System;
using Xunit;

namespace AreaTest
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleConstructorNegativeSideLengthTest()
        {
            Action a;
            ArgumentException e;

            // Arrage
            a = () => new Triangle(-8, 2.2f, 11);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sides of the triangle must be greater than zero.", e.Message);

            // Arrage
            a = () => new Triangle(8, -2.2f, 11);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sides of the triangle must be greater than zero.", e.Message);

            // Arrage
            a = () => new Triangle(8, 2.2f, -11);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sides of the triangle must be greater than zero.", e.Message);

            // Arrage
            a = () => new Triangle(-8, -2.2f, 11);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sides of the triangle must be greater than zero.", e.Message);

            // Arrage
            a = () => new Triangle(-8, 2.2f, -11);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sides of the triangle must be greater than zero.", e.Message);

            // Arrage
            a = () => new Triangle(8, -2.2f, -11);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sides of the triangle must be greater than zero.", e.Message);

            // Arrage
            a = () => new Triangle(-8, -2.2f, -11);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sides of the triangle must be greater than zero.", e.Message);

        }

        [Fact]
        public void TriangleConstructorSidesSumTest()
        {
            Action a;
            ArgumentException e;

            // Arrage
            a = () => new Triangle(15, 3, 9);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sum of the lengths of each two sides must be greater than the length of the third side.", e.Message);

            // Arrage
            a = () => new Triangle(1, 3, 9);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sum of the lengths of each two sides must be greater than the length of the third side.", e.Message);

            // Arrage
            a = () => new Triangle(2, 7, 4);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sum of the lengths of each two sides must be greater than the length of the third side.", e.Message);

            // Arrage
            a = () => new Triangle(3, 3, 6);
            // Act/Assert
            e = Assert.Throws<ArgumentException>(a);
            Assert.Equal("The sum of the lengths of each two sides must be greater than the length of the third side.", e.Message);
        }

        [Fact]
        public void TriangleAreaTest()
        {

            Triangle t;

            // Arrage/Act
            t = new Triangle(3, 3, 3);

            // Assert
            Assert.Equal((MathF.Sqrt(3)/4)*3*3, t.Area);

            // Arrage/Act
            t = new Triangle(3, 4, 5);

            // Assert
            Assert.Equal(6, t.Area);

        }

        [Fact]
        public void RightTriangleTest()
        {

            Triangle t;

            // Arrage/Act
            t = new Triangle(3, 3, 3);

            // Assert
            Assert.False(t.IsRightTriangle);

            // Arrage/Act
            t = new Triangle(3, 4, 5);

            // Assert
            Assert.True(t.IsRightTriangle);

        }

    }
}
