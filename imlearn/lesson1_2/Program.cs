namespace lesson1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Переменные
            //Создайте три переменные с именами score, Score и SCORE. Присвойте им разные значения и выведите все три на экран.

            //int score = 10;
            //int Score = 100;
            //int SCORE = 1000;

            //Console.WriteLine(score);
            //Console.WriteLine(Score);
            //Console.WriteLine(SCORE);

            //**********************************************//

            //2.Базовые типы данных(string, int, bool) !!
            //Объявите переменные:
            //name типа string со значением "Бакштай Виталий",
            //age типа int со значением 25,
            //isStudent типа bool со значением true.
            //Выведите их значения на консоль.(Console.WriteLine)

            //string developer = "Бакштай Виталий";
            //int age = 25;
            //bool isStudent = true;

            //Console.WriteLine(developer);
            //Console.WriteLine(age);
            //Console.WriteLine(isStudent);

            //**********************************************//

            //3.Символы и управляющие последовательности
            //Выведите на экран строку:
            //Он сказал: "Привет\n\tМир!"
            //так, чтобы она отобразилась именно с новой строки и табуляцией.

            //Console.WriteLine("Он сказал: \"Привет\n\tМир!\"");

            //**********************************************//

            //4.Типы данных и диапазоны значений !!
            //Объявите переменные всех целочисленных типов(byte, sbyte, short, ushort, int, uint, long, ulong) и присвойте им максимальные допустимые значения. Выведите их.

            //byte b = 255;
            //sbyte sb = 127;
            //short s = 32767;
            //ushort us = 65535;
            //int i = 2147483647;
            //uint ui = 4294967295;
            //long l = 9223372036854775807;
            //ulong ul = 18446744073709551615;

            //Console.WriteLine(b.ToString());
            //Console.WriteLine(sb.ToString());
            //Console.WriteLine(s.ToString());
            //Console.WriteLine(us.ToString());
            //Console.WriteLine(i.ToString());
            //Console.WriteLine(ui.ToString());
            //Console.WriteLine(l.ToString());
            //Console.WriteLine(ul.ToString());

            //**********************************************//

            //5.Неявная типизация(var)!!
            //Используя var, создайте переменные для хранения:
            //строки "C#"
            //целого числа 2026
            //символа '!'

            //var num = 2026;
            //var c = '!';

            //**********************************************//

            //6.Преобразование ввода(Convert)!!
            //Запросите у пользователя(Console.ReadLine):
            //целое число(возраст),
            //вещественное число(вес),
            //десятичное число(зарплата).
            //Преобразуйте ввод с помощью Convert и выведите результат.


            //Console.WriteLine("Введите возраст:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите вес:");
            //double w = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Введите зарплату:");
            //decimal s = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine($"Возраст: {a}; Вес: {w}; Зарплата: {s}");

            //**********************************************//

            //7.Явное и неявное преобразование типов !!
            //Присвойте int a = 300; и попробуйте преобразовать его в byte двумя способами:
            //без checked(выведите результат),
            //с checked(обработайте исключение OverflowException).

            //int a = 300;

            //Console.WriteLine((byte)a);

            //checked
            //{
            //    try
            //    {
            //        Console.WriteLine((byte)a);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Ошибка");
            //    }
            //}

            //**********************************************//

            //8.Упаковка и распаковка(boxing/ unboxing)
            //Упакуйте целое число 42 в переменную типа object, затем распакуйте обратно в int и выведите результат.

            //int i = 42;

            //object o = i;

            //i = (int)o;

            //Console.WriteLine(i);

            //**********************************************//

            //9.Преобразование через Parse !!
            //Напишите программу, которая пытается преобразовать строку "123" в int с помощью int.Parse().

            //string s = "123";

            //int.Parse(s);

            //**********************************************//

            //10.Проверка типа(is, as)!!
            //Создайте переменную object obj = "Hello";.
            //Проверьте с помощью is, является ли она строкой, и если да — выведите её.
            //Попробуйте преобразовать с помощью as и выведите результат, если не null.

            //object obj = "Hello";

            //if (obj is string) Console.WriteLine(obj);

            //if (obj as string != null) Console.WriteLine(obj);

            //**********************************************//

            //11.Условные конструкции(if-else)
            //Напишите программу, которая запрашивает два числа и выводит, какое из них больше, или сообщает, что они равны.

            //int i1 = Convert.ToInt32(Console.ReadLine());

            //int i2 = Convert.ToInt32(Console.ReadLine());

            //if (i1 > i2) Console.WriteLine("i1 > i2");
            //else if (i1 < i2) Console.WriteLine("i1 < i2");
            //else Console.WriteLine("i1 == i2");

            //**********************************************//

            //12.Тернарный оператор
            //Напишите программу, которая определяет, является ли число положительным:
            //если да — выводит "Положительное", иначе — "Не положительное", используя тернарный оператор.

            //Console.WriteLine(Convert.ToInt32(Console.ReadLine()) > 0 ? "Положительное" : "Не положительное");

            //**********************************************//

            //13.Конструкция switch
            //Напишите программу, которая запрашивает оценку(1–5) и выводит:
            //5 → «Отлично»
            //4 → «Хорошо»
            //3 → «Удовлетворительно»
            //2 или 1 → «Неудовлетворительно»
            //иное → «Неверная оценка»

            //switch(Convert.ToInt32(Console.ReadLine()))
            //{
            //    case 5:
            //        Console.WriteLine("Отлично");
            //        break;
            //    case 4:
            //        Console.WriteLine("Хорошо");
            //        break;
            //    case 3:
            //        Console.WriteLine("Удовлетворительно");
            //        break;
            //    case 2:
            //    case 1:
            //        Console.WriteLine("Неудовлетворительно");
            //        break;
            //    default:
            //        Console.WriteLine("Неверная оценка");
            //        break;
            //}

            //**********************************************//

            //14.Цикл for
            //Напишите программу, которая вычисляет сумму всех нечётных чисел от 1 до 99 с помощью цикла for.

            //int sum = 0;

            //for(int i = 1; i <= 99; i++)
            //{
            //    if (i%2 != 0) sum += i;
            //}

            //**********************************************//

            //15.Объявление и инициализация одномерного массива !!
            //Объявите массив double из 5 элементов, инициализируйте его любыми значениями.
            //Выведите длину массива и его третий элемент.

            //double[] arr = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };

            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr[3]);

            //**********************************************//

            //16.Перебор массива с помощью foreach !!
            //Создайте массив строк: { "apple", "BANANA", "Cherry"}.
            //С помощью foreach выведите каждую строку в нижнем регистре.

            //string[] arr = new string[] { "apple", "BANANA", "Cherry" };

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item.ToLower());
            //}
        }
    }
}
