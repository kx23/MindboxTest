using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLib
{
    class Rectangle:Figure
    {
        private float side1;
        private float side2;

        public bool IsSquare { get; private set; }

        public Rectangle(float side1,float side2)
        {
            if (side1 <= 0||side2<=0)
            {
                throw new ArgumentException("The sides of the rectangle must be greater than zero.");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.IsSquare = side1==side2;
            this.Area = CalculateArea();
        }

        protected override float CalculateArea()
        {
            return side1 * side2;
        }
    }
}
