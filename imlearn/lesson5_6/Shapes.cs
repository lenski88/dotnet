//Задача 8: Полиморфизм - Фигуры(!!)
//Создайте базовый класс Shape

//Метод double GetArea()

//Создайте производные классы:

//Rectangle со свойствами Width Height

//Circle со свойством Radius

//Реализуйте для каждого производного класса свой метод расчёта площади double GetArea()


//В Main-е:
//Создайте массив Shape[]

//Пройдитесь просто циклом и выведите площадь каждой фигуры

namespace lesson5_6
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public override double GetArea() => Width * Height;
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
