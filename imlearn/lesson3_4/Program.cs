using lesson3_4.Enams;

namespace lesson3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        //1. Подсчёт гласных
        //Напишите метод CountVowels(string text), который возвращает количество гласных букв(а, е, ё, и, о, у, ы, э, ю, я) в строке без учёта регистра.

        //public static int CountVowels(string text)
        //{
        //    string vowels = "аеёиоуыэюя";

        //    int sum = 0;

        //    foreach (var c in text)
        //    {
        //        if (vowels.Contains(c))
        //        {
        //            sum += 1;
        //        }
        //    }

        //    return sum;
        //}

        //*********************************************************//

        //2. Переворот слов(!!)
        //Напишите метод ReverseWords(string text), который переворачивает порядок слов в строке.
        //Пример: "Я изучаю Шарпы" → "Шарпы изучаю Я"

        //public static string ReverseWords(string text)
        //{
        //    return string.Join(" ", text.Split(" ").Reverse().ToArray());
        //}

        //*********************************************************//

        //3.Создайте класс GeometryHelper с методами:
        //double CircleArea(double radius)
        //double RectangleArea(double a, double b)

        //public static class GeometryHelper
        //{
        //    public static double CircleArea(double radius)
        //    {
        //        return Math.PI * Math.Sqrt(radius);
        //    }

        //    public static double RectangleArea(double a, double b)
        //    {
        //        return a * b;
        //    }
        //}

        //*********************************************************//

        //4.Валидация пароля(!!)
        //Напишите метод boolean IsValidPassword(string password), проверяющий, что пароль:
        //длиной ≥ 8 символов
        //содержит хотя бы одну цифру
        //содержит хотя бы одну заглавную букву

        //public static bool IsValidPassword(string password)
        //{
        //    if (password.Length < 8)
        //    {
        //        return false;
        //    }

        //    bool hasNumber = false;
        //    bool hasUpperLetter = false;

        //    foreach (char item in password)
        //    {
        //        if (hasNumber && hasUpperLetter)
        //        {
        //            break;
        //        }

        //        if (char.IsDigit(item))
        //        {
        //            hasNumber = true;
        //        }

        //        if (char.IsUpper(item)) {
        //            hasUpperLetter = true;
        //        }

        //    }

        //    return hasNumber && hasUpperLetter;
        //}

        //*********************************************************//

        //5.Генератор приветствия
        //Метод string Greet(string name, int hour) возвращает приветствие в зависимости от времени суток:
        //0–5 - «Доброй ночи», 6–11 - «Доброе утро», 12–17 - «Добрый день», 18–23 - «Добрый вечер».

        //public static string Greet(string name, int hour)
        //{
        //    return hour switch
        //    {
        //        >= 0 and <= 5 => "Доброй ночи, " + name,
        //        >= 6 and <= 11 => "Доброе утро, " + name,
        //        >= 12 and <= 17 => "Добрый день, " + name,
        //        >= 18 and <= 23 => "Добрый вечер, " + name,
        //        _ => "Невалидный ввод"
        //    };
        //}

        //*********************************************************//

        //6.Дни недели(!!)
        //Создайте enum Day { MONDAY, TUESDAY, ..., SUNDAY }
        //с методом IsWeekend(), возвращающим true для субботы и воскресенья.

        //public static bool IsWeekend(Days day)
        //{
        //    return new[] { Days.Saturday, Days.Sunday }.Contains(day);
        //}

        //*********************************************************//

        //7. Оценки(!!)
        //Создайте enum Grade { A(5), B(4), C(3), D(2), F(1) } с полем int numericValue.Реализуйте метод IsPassed(), возвращающий true, если оценка ≥ 3.

        //public static bool IsPassed(Grade gr)
        //{
        //    return (int)gr >= 3;
        //}

        //*********************************************************//

        //8.Направления движения(!!)
        //enum Direction { NORTH, SOUTH, EAST, WEST }
        //с методом Direction Opposite(), возвращающим противоположное направление.

        //public static Direction Opposite(Direction dir)
        //{
        //    switch(dir)
        //    {
        //        case Direction.NORTH:
        //            return Direction.SOUTH;
        //        case Direction.SOUTH:
        //            return Direction.NORTH;
        //        case Direction.WEST:
        //            return Direction.EAST;
        //        case Direction.EAST:
        //            return Direction.WEST;
        //        default:
        //            throw new ArgumentException();
        //    }
        //}

        //*********************************************************//

    }
}
