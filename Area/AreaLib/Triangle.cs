using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLib
{
    public class Triangle:Figure
    {
        private float side1;
        private float side2;
        private float side3;

        public bool IsRightTriangle { get; private set; }

        public Triangle(float side1, float side2, float side3)
        {
            // проверка на отрицательные стороны
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("The sides of the triangle must be greater than zero.");
            }
            // проверка на длинну сторон. Сумма двух любых сторон должна быть больше третей стороны.
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                throw new ArgumentException("The sum of the lengths of each two sides must be greater than the length of the third side.");
            }

            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;

            float longestSide = MathF.Max(side3, MathF.Max(side1, side2)); //возможная гипотенуза
            this.IsRightTriangle = longestSide * longestSide == side1 * side1 + side2 * side2 + side3 * side3 - longestSide * longestSide;// проверка теоремы Пифагора
            this.Area = CalculateArea();
        }

        protected override float CalculateArea()
        {
            float p = (side1 + side2 + side3)/2f; // полупериметр
            return MathF.Sqrt(p * (p - side1) * (p - side2) * (p - side3)); // Формула Герона
        }
    }
}
