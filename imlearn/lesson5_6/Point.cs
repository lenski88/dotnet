
//Задача 1: Точка на плоскости(!!)
//Создайте структуру Point, которая:
//хранит X и Y (int) свойства.
//имеет метод DistanceFromZero(), возвращающий расстояние до начала координат.
//Формула(формула √(x² + y²)

namespace lesson5_6
{
    struct Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public readonly int DistanceFromZero()
        {
            return (int)Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }
}
