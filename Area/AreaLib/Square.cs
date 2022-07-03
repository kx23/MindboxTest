using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLib
{
    class Square:Figure
    {
        private float side;

        public Square(float side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Side is not greater than 0.");
            }

            this.side = side;
            this.Area = CalculateArea();
        }

        protected override float CalculateArea()
        {
            return side*side;
        }
    }
}
