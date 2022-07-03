using System;

namespace AreaLib
{
    public class Circle:Figure
    {

        private float radius;

        public Circle(float radius)
        {
            // проверка на отрицательный радиус
            if (radius <= 0)
            {
                throw new ArgumentException("Radius is not greater than 0.");
            }

            this.radius = radius;
            this.Area = CalculateArea();
        }

        protected override float CalculateArea()
        {
            return MathF.PI * radius*radius;// формула площади круга
        }
    }
}
