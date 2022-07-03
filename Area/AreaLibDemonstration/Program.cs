using System;
using AreaLib; // подключение пространства имен из библиотеки классов. Предварительно добавляем AreaLib в зависимости AreaLibDemonstration.


namespace AreaLibDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3f, 4f, 5f);
            Console.WriteLine("Треугольник имеет площадь {0}. Треугольник{1} является прямоугольным.",triangle.Area,triangle.IsRightTriangle?"":" не");
            
            triangle = new Triangle(3f, 4f, 6f);
            Console.WriteLine("Треугольник имеет площадь {0}. Треугольник{1} является прямоугольным.", triangle.Area, triangle.IsRightTriangle ? "" : " не");

            Circle circle = new Circle(2);
            Console.WriteLine("Круг имеет площадь {0}.", circle.Area);

        }
    }
}
