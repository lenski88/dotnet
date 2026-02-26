using System.Diagnostics;
using System.Xml.Linq;

namespace extra0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MathUtils.Calculate(1, 2));
            //Console.WriteLine(MathUtils.Calculate(1, 2, Operations.Sum));
            //Console.WriteLine(MathUtils.Calculate(1, 2, Operations.Sub));
            //Console.WriteLine(MathUtils.Calculate(1, 2, Operations.Mul));
            //Console.WriteLine(MathUtils.Calculate(1, 2, Operations.Div));

            //Printer.Print("sss");

            //Printer.Print("sss", 5);

            //Printer.Print("sss", 5, "_");

            //Company.Developer.Employee dev = new Company.Developer.Employee();
            //Company.HR.Employee hr = new Company.HR.Employee();

            //Color[] colors = new Color[] { new Color(255, 0, 0), new Color(0, 255, 0), new Color(0, 0, 255) };

            //foreach (var color in colors)
            //{
            //    Console.WriteLine($"Яркость: {color.GetBrightness()}");
            //    Console.WriteLine($"HEX: {color.ToHexString()}");
            //    Console.WriteLine();
            //}

            //for (var i = 0; i < 5; i++)
            //{
            //    new Counter();
            //}

            //Console.WriteLine(Counter.GetTotalCount());

            //List<IPayable> staff = new List<IPayable>()
            //{
            //    new Employee(10),
            //    new Employee(20),
            //    new Employee(30),
            //    new Freelancer(1.1m, 10),
            //    new Freelancer(2.2m, 20),
            //    new Freelancer(3.3m, 30),
            //};

            //foreach (var sm in staff)
            //{
            //    Console.WriteLine(sm.GetPaymentAmount());
            //}

            //List<Shape> shapes = new List<Shape>()
            //{
            //    new Circle(10),
            //    new Circle(20),
            //    new Circle(30),
            //    new Rectangle(10, 20),
            //    new Rectangle(30, 40),
            //    new Rectangle(50, 60),
            //};

            //foreach (var shape in shapes)
            //{
            //    Console.WriteLine(shape.Describe());
            //}

            //******************************************************************//

            //13. Анонимные типы
            //Дан массив строк с названиями фруктов: {"Apple", "Banana", "Cherry"}.
            //Используя LINQ и анонимные типы, создайте новую коллекцию объектов, где каждый объект содержит:
            //Название фрукта.
            //Длину названия.
            //Флаг IsShort, равный true, если длина меньше 6 символов.
            //Выведите результаты на экран, используя цикл foreach с ключевым словом var.

            //string[] fruitNames = new string[] { "Apple", "Banana", "Cherry" };

            //var fruits = fruitNames.Select(_ => new { Name = _, NameLegth = _.Length, IsShort = _.Length < 6 });

            //foreach (var fruit in fruits)
            //{
            //    Console.WriteLine($"Name: {fruit.Name}; NameLength: {fruit.NameLegth}; IsShort: {fruit.IsShort}");
            //}

            //User user = new User(1, "user1", "user1@users.dom");

            //user.ValidateEmail();

            //Box<string> bs1 = new Box<string>("bs1con");
            //Box<string> bs2 = new Box<string>("bs2con");

            //Console.WriteLine(bs1.Content);
            //Console.WriteLine(bs2.Content);

            //bs1.SwapContent(bs2);

            //Console.WriteLine();

            //Console.WriteLine(bs1.Content);
            //Console.WriteLine(bs2.Content);


            //Box<int> bi1 = new Box<int>(1);
            //Box<int> bi2 = new Box<int>(2);

            //Console.WriteLine(bi1.Content);
            //Console.WriteLine(bi2.Content);

            //bi1.SwapContent(bi2);

            //Console.WriteLine();

            //Console.WriteLine(bi1.Content);
            //Console.WriteLine(bi2.Content);

            //Box<BoxItem> bitem1 = new Box<BoxItem>(new BoxItem() { Inner = "bitem1con" });
            //Box<BoxItem> bitem2 = new Box<BoxItem>(new BoxItem() { Inner = "bitem2con" });

            //Console.WriteLine(bitem1.Content.Inner);
            //Console.WriteLine(bitem2.Content.Inner);

            //bitem1.SwapContent(bitem2);

            //Console.WriteLine();

            //Console.WriteLine(bitem1.Content.Inner);
            //Console.WriteLine(bitem2.Content.Inner);

            //******************************************************************//

            //17.Коллекции
            //Используйте словарь Dictionary<string, List<int>> для хранения оценок студентов(Ключ — имя студента, Значение — список оценок).
            //Добавьте данные для 3 студентов.
            //Напишите логику для добавления новой оценки существующему студенту.
            //Найдите студента со средним баллом выше 4.5 и выведите его имя.
            //Попробуйте обратиться к несуществующему студенту, используя метод TryGetValue для безопасной обработки.

            //Dictionary<string, List<int>> studDict = new Dictionary<string, List<int>>();

            //studDict.Add("stud1", new List<int>() { 1, 2, 3 });
            //studDict.Add("stud2", new List<int>() { 2, 3, 4 });
            //studDict.Add("stud3", new List<int>() { 5, 5, 5 });

            //AddValueToKey(studDict, "stud1", 1);
            //AddValueToKey(studDict, "stud2", 2);
            //AddValueToKey(studDict, "stud1", 5);

            //foreach (var item in studDict)
            //{
            //    if ((item.Value.Aggregate(0, (cur, next) => cur + next) / item.Value.Count) > 4.5)
            //    {
            //        Console.WriteLine(item.Key);
            //    }
            //}

            //if (studDict.TryGetValue("111", out var list))
            //{
            //    //
            //}
            //else
            //{
            //    Console.WriteLine("111 не найден");
            //}

            //******************************************************************//

            //18.LINQ
            //Дан список объектов Product(свойства: Name, Price, Category).
            //Напишите запрос LINQ(можно в синтаксисе методов или запросов), который:
            //            Фильтрует товары категории "Electronics".
            //Отбирает только те, цена которых выше 1000.
            //Сортирует их по цене по убыванию.
            //Выбирает только названия товаров(проекция).
            //Выводит первые 3 результата.

            //List<Product> products = new List<Product>();

            //for (int i = 1; i <= 10; i++)
            //{
            //    products.Add(new Product($"product{i}", (uint)i * 1000, i % 2 == 0 ? "Electronics" : "Industrial"));
            //}

            //foreach (var prName in products
            //    .Where(_ => _.Category == "Electronics")
            //    .Where(_ => _.Price > 1000)
            //    .OrderByDescending(_ => _.Price)
            //    .Select(_ => _.Name)
            //    .Take(3))
            //{
            //    Console.WriteLine(prName);
            //}

        }


        //1. Преобразование базовых типов данных
        //Напишите программу, которая запрашивает у пользователя ввод строки, представляющей число с плавающей точкой(например, "12.5" или "3,14", учитывая культуру). 
        //Преобразуйте эту строку в тип double, умножьте значение на 2 и преобразуйте результат обратно в строку с форматированием до двух знаков после запятой.
        //static void Prompt1()
        //{
        //    Console.Write("Введите число с плавающей точкой: ");

        //    if (double.TryParse(Console.ReadLine()?.Replace(",", "."), CultureInfo.InvariantCulture, out double input))
        //    {
        //        Console.Write((input * 2).ToString("F2"));
        //    }
        //    else
        //    {
        //        Console.Write("Некорректный ввод");
        //    }
        //}

        //******************************************************************//

        //2. Массивы
        //Дан массив целых чисел int[] numbers.Напишите метод, который:
        //Находит минимальное и максимальное значение в массиве.
        //Создает новый массив, содержащий только те элементы исходного массива, которые больше среднего арифметического всех элементов.
        //Возвращает этот новый массив.

        //static int[] FilterArrayByAverage(int[] arr)
        //{
        //    if (arr == null || arr.Length == 0)
        //    {
        //        return Array.Empty<int>();
        //    }

        //    Array.Sort(arr);

        //    int min = arr[0];
        //    int max = arr[arr.Length - 1];

        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        sum += item;
        //    }

        //    int av = sum / arr.Length;

        //    int count = 0;

        //    foreach (var item in arr)
        //    {
        //        if (item > av)
        //        {
        //            count++;
        //        }
        //    }

        //    int[] result = new int[count];
        //    int index = 0;

        //    foreach (var item in arr)
        //    {
        //        if (item > av)
        //        {
        //            result[index++] = item;
        //        }
        //    }

        //    return result;
        //}

        //******************************************************************//

        //3. Символы и строки
        //Напишите программу, которая принимает предложение от пользователя и выполняет следующее:
        //Подсчитывает количество гласных букв(без учета регистра).
        //Заменяет все пробелы на символ подчеркивания _.
        //Выводит строку в обратном порядке.
        //Используйте методы класса string и работу с char.

        //static void Prompt2()
        //{
        //    Console.Write("Введите строку: ");

        //    string input = Console.ReadLine();

        //    if (input != null)
        //    {
        //        string vowels = "аеёиоуыэюя";

        //        int vowelsCount = 0;

        //        foreach (var item in input)
        //        {
        //            if (vowels.Contains(input.ToLower()))
        //            {
        //                vowelsCount++;
        //            }
        //        }

        //        string replaced = input.Replace(' ', '_');

        //        StringBuilder sb = new StringBuilder();

        //        for(var i = replaced.Length - 1; i >= 0; i--)
        //        {
        //            sb.Append(replaced[i]);
        //        }

        //        Console.WriteLine(sb.ToString());
        //    }
        //}

        //******************************************************************//

        //5. Enums(Перечисления)
        //Объявите перечисление TrafficLight со значениями Red, Yellow, Green. Напишите метод GetAction(TrafficLight light), который возвращает строковое описание действия:
        //Red -> "Красный не идём"
        //Yellow -> "Жёлтый ожидаем"
        //Green -> "Зелёный можно идти"
        //Используйте конструкцию switch для реализации логики.Выведите действия для всех возможных значений перечисления в цикле.

        //static string GetAction(TrafficLight light)
        //{
        //    return light switch
        //    {
        //        TrafficLight.Red => "Красный не идём",
        //        TrafficLight.Yellow => "Жёлтый ожидаем",
        //        TrafficLight.Green => "Зелёный можно идти",
        //        _ => "Странно"
        //    };
        //}

        //******************************************************************//

        //15. Работа с датой и временем
        //Напишите программу, которая:
        //Принимает дату рождения пользователя.
        //Вычисляет точный возраст в годах.
        //Определяет, сколько дней осталось до следующего дня рождения.
        //Выводит день недели, в который пользователь родился.
        //Используйте класс DateTime и TimeSpan.

        //static void GetBirthdayInfo(DateTime birthday)
        //{
        //    DateTime today = DateTime.Today;

        //    // возраст в годах
        //    int age = today.Year - birthday.Year;

        //    if (today.Month < birthday.Month || (today.Month == birthday.Month && today.Day < birthday.Day))
        //    {
        //        age--;
        //    }

        //    Console.WriteLine(age);

        //    DateTime nextBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);

        //    if (today > nextBirthday)
        //    {
        //        nextBirthday = nextBirthday.AddYears(1);
        //    }

        //    // количество дней до след др
        //    int daysUntilNextBirthday = (nextBirthday - today).Days;

        //    Console.WriteLine(daysUntilNextBirthday);

        //    //день недели, в который родился юзер
        //    Console.WriteLine(birthday.DayOfWeek);
        //}

        //static void AddValueToKey(Dictionary<string, List<int>> dict, string key, int grade)
        //{
        //    if (grade < 0 || grade > 5)
        //    {
        //        return;
        //    }

        //    if (dict.TryGetValue(key, out List<int>? list))
        //    {
        //        list.Add(grade);
        //    }
        //}
    }
}
