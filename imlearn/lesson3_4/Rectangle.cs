namespace lesson3_4
{
    //11.Прямоугольник(!!)
    //Класс Rectangle с автосвойствами Width, Height.Методы:
    //GetArea() → площадь
    //GetPerimeter() → периметр
    //IsSquare() → является ли квадратом

    public class Rectangle
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }

        public int GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public bool IsSquare()
        {
            return Width == Height;
        }
    }
}
