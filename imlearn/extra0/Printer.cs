//7.Перегрузка
//Создайте класс Printer. Реализуйте в нем три перегруженных метода с именем Print:
//Print(string text) — выводит текст в консоль.
//Print(string text, int count) — выводит текст указанное количество раз.
//Print(string text, int count, string prefix) — выводит текст указанное количество раз с добавлением префикса перед каждой строкой.
//Продемонстрируйте вызов всех трех версий метода.

namespace extra0
{
    static class Printer
    {
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        public static void Print(string text, int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(text);
            }
        }

        public static void Print(string text, int count, string prefix)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{prefix}{text}");
            }
        }
    }
}
