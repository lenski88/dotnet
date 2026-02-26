//12.ООП(Наследование и Полиморфизм)
//Создайте базовый абстрактный класс Shape с абстрактным методом double GetArea() и виртуальным методом string Describe().
//Создайте наследников Circle (радиус) и Rectangle (ширина, высота).
//Реализуйте вычисление площади в каждом наследнике.
//Переопределите метод Describe() так, чтобы он выводил тип фигуры и её площадь.
//Продемонстрируйте полиморфизм, храня объекты разных фигур в списке типа List<Shape> и вызывая методы через базовый тип.

namespace extra0
{
    abstract class Shape
    {
        public abstract double GetArea();

        public virtual string Describe()
        {
            return "i'm shape";
        }
    }

    class Circle(int radius) : Shape
    {
        public int Radius { get; init; } = radius;

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string Describe()
        {
            return ShapeDescriber.Describe(this);
        }
    }

    class Rectangle(int width, int height) : Shape
    {
        public int Width { get; init; } = width;

        public int Height { get; init; } = height;

        public override double GetArea()
        {
            return Width * Height;
        }

        public override string Describe()
        {
            return ShapeDescriber.Describe(this);
        }
    }

    static class ShapeDescriber
    {
        public static string Describe(Shape shape)
        {
            return $"Shape: {shape.GetType().Name}; Area: {shape.GetArea()}";
        }
    }
}
