using System.Threading.Channels;

namespace lesson9_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.Работа с числами(LINQ) (!!)
            //Дан список чисел:
            //List<int> numbers = new List<int> { 5, 12, 7, 20, 33, 18, 2, 40 };

            //Требуется:
            //Получить все чётные числа
            //Отсортировать их по возрастанию
            //Умножить каждое число на 3
            //Сохранить результат в новый список
            //Вывести результат

            //IEnumerable<int> numbers = new int[] { 5, 12, 7, 20, 33, 18, 2, 40 }
            //    .Where(n => n % 2 == 0)
            //    .Order()
            //    .Select(n => n * 3);

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //*********************************************************************//

            //Задание 2.Фильтрация объектов(LINQ)(!!)
            //Условие
            //Создайте класс:
            //class Product
            //        {
            //            public string Name { get; set; }
            //            public double Price { get; set; }
            //            public int Quantity { get; set; }
            //        }

            //Создайте список из 5 товаров.
            //Требуется:
            //Найти товары, цена которых больше 100
            //Отсортировать по цене по убыванию
            //Получить список названий товаров
            //Вывести названия

            //IEnumerable<string> productNames = new Product[]
            //{
            //    new Product() { Name = "product1", Price = 10, Quantity = 10 },
            //    new Product() { Name = "product2", Price = 20, Quantity = 20 },
            //    new Product() { Name = "product3", Price = 300, Quantity = 30 },
            //    new Product() { Name = "product4", Price = 400, Quantity = 40 },
            //    new Product() { Name = "product5", Price = 500, Quantity = 50 },
            //}
            //    .Where(p => p.Price > 100)
            //    .OrderByDescending(p => p.Price)
            //    .Select(p => p.Name);

            //foreach (var productName in productNames)
            //{
            //    Console.WriteLine(productName);
            //}

            //*********************************************************************//

            //Задание 3.Проверки(LINQ)(!!)
            //Условие
            //Создайте список студентов с оценками(int).
            //class Student
            //{
            //    public int Grade { get; set; }
            //}

            //Требуется:
            //Проверить, есть ли хотя бы одна оценка меньше 3
            //Проверить, все ли оценки больше или равны 4
            //Посчитать количество оценок выше 4

            //IEnumerable<Student> students = new Student[]
            //{
            //    new Student() { Grade = 2},
            //    new Student() { Grade = 4},
            //    new Student() { Grade = 6},
            //    new Student() { Grade = 8},
            //    new Student() { Grade = 10},
            //};

            //Console.WriteLine(students.Any(s => s.Grade < 3));

            //Console.WriteLine(students.All(s => s.Grade > 4));

            //Console.WriteLine(students.Aggregate(0, (cur, next) => next.Grade > 4 ? cur + next.Grade : cur));

            //*********************************************************************//

            //Задание 4.Агрегация(LINQ)(!!)
            //Используя список чисел:
            //List<int> numbers = new List<int> { 5, 12, 7, 20, 33, 18, 2, 40 };
            //Требуется:
            //Найти сумму всех чётных чисел
            //Найти максимальное число
            //Найти среднее арифметическое

            //List<int> numbers = new List<int> { 5, 12, 7, 20, 33, 18, 2, 40 };

            //Console.WriteLine(numbers.Aggregate(0, (cur, next) => next % 2 == 0 ? cur + next : cur));

            //Console.WriteLine(numbers.Max());

            //Console.WriteLine(numbers.Aggregate(0, (cur, next) => cur + next) / numbers.Count);

            //*********************************************************************//

            //Задание 5.Группировка(LINQ)(!!)
            //Дан список чисел:
            //List<int> numbers = new List<int> { 5, 12, 7, 20, 33, 18, 2, 40 };
            //Требуется:
            //Сгруппировать числа по признаку: чётные / нечётные
            //Вывести группы и элементы каждой группы

            //IEnumerable<NumbersGroup> numbersGroup = new List<int> { 5, 12, 7, 20, 33, 18, 2, 40 }
            //    .GroupBy(n => n % 2 == 0, (gr, nums) => new NumbersGroup() { Group = gr ? "even" : "odd", Numbers = nums })

            //foreach (var numGroup in numbersGroup)
            //{
            //    Console.WriteLine(numGroup.Group);

            //    foreach (var num in numGroup.Numbers)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //*********************************************************************//

            //Задание 6.Фильтрация объектов(LINQ)(!!)
            //Создайте класс:
            //class Person
            //{
            //    public string Name { get; set; }
            //    public int Age { get; set; }
            //}
            //Создайте список из 5 персон.
            //Требуется:
            //Найти всех людей старше 18 лет
            //Отсортировать по возрасту
            //Вывести имена

            //IEnumerable<Person> persons = new Person[]
            //{
            //    new Person() {Name = "person1", Age = 10 },
            //    new Person() {Name = "person2", Age = 20 },
            //    new Person() {Name = "person3", Age = 30 },
            //    new Person() {Name = "person4", Age = 40 },
            //    new Person() {Name = "person5", Age = 50 },
            //};

            //IEnumerable<string> personNames = persons
            //    .Where(p => p.Age > 18)
            //    .Select(p => p.Name);

            //foreach (var name in personNames)
            //{
            //    Console.WriteLine(name);
            //}

            //*********************************************************************//

            //Задание 7.Поиск(LINQ)(!!)
            //Используя список персон ранее объявленных.

            //Требуется:
            //Найти первого человека с возрастом больше 30
            //Если такого нет — вывести сообщение “Такого не существует”

            //Person match = persons.FirstOrDefault(p => p.Age > 30);

            //if (match == null)
            //{
            //    Console.WriteLine("Такого не существует");
            //}

            //*********************************************************************//

            //Задание 8.Проверки(LINQ)(!!)
            //Используя список персон ранее объявленных.

            //Требуется:
            //Проверить, есть ли человек младше 25
            //Проверить, все ли люди старше 18

            //Console.WriteLine(persons.Any(p => p.Age < 25));

            //Console.WriteLine(persons.All(p => p.Age > 18));

            //*********************************************************************//

            //Задание 9.Фильтрация строк(LINQ)(!!)
            //Дан список строк:
            //List<string> words = new() { "Artem", "Natali", "Yana", "Yulia", "Alex" };

            //Требуется:
            //Оставить строки длиной больше 4
            //Отсортировать по алфавиту
            //Вывести результат

            // IEnumerable<string> words = new List<string>() { "Artem", "Natali", "Yana", "Yulia", "Alex" };

            //foreach (var word in words.Where(w => w.Length > 4).Order())
            //{
            //    Console.WriteLine(word);
            //}

            //*********************************************************************//

            //Задание 10.Поиск подстрок(LINQ)(!!)
            //Используя ранее объявленный words

            //Требуется:
            //Найти все слова, содержащие букву “a”
            //Привести их к верхнему регистру
            //Получить список

            //foreach (var word in words.Where(w => w.ToLower().Contains('a')).Select(w => w.ToUpper()))
            //{
            //    Console.WriteLine(word);
            //}

            //*********************************************************************//

            //Задание 11.Уникальные элементы(LINQ)(!!)
            //Дан список чисел с повторениями.

            //Требуется:
            //Получить список уникальных чисел
            //Отсортировать по убыванию

            //IEnumerable<int> nums = new int[] { 1, 2, 4, 4, 66, 6, 3, 1, 5 }
            //    .GroupBy(n => n)
            //    .Where(g => g.Count() == 1)
            //    .Select(g => g.Key)
            //    .OrderDescending();


            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //*********************************************************************//

            //Задание 12.Вложенные коллекции(LINQ)(!!)
            //Создайте класс:
            //class Order
            //{
            //    public int Id { get; set; }
            //    public List<int> Prices { get; set; }
            //}

            //Создайте список минимум из 2 заказов.

            //Требуется:
            //Получить список всех цен из всех заказов
            //Найти максимальную цену

            //int maxPrice = new Order[]
            //{
            //    new Order() { Id = 0, Prices = [1, 10, 100] },
            //    new Order() { Id = 1, Prices = [2, 20, 200] },
            //}
            //    .Aggregate(new List<int>(), (cur, next) => { next.Prices.ForEach(p => cur.Add(p)); return cur; })
            //    .Max();

            //*********************************************************************//

            //Задание 13.Action с объектом(!!)
            //Условие
            //Создайте класс:
            //class User
            //{
            //    public string Name { get; set; }
            //    public int Age { get; set; }
            //}

            //Требуется:
            //Создать Action<User>
            //Action должен выводить информацию о пользователе в формате:
            // Имя: ..., Возраст: ...
            //Вызвать Action для объекта User

            //Action<User> getUserInfo = (user) => Console.WriteLine($"Имя: {user.Name}, Возраст: {user.Age} ");


            //*********************************************************************//

            //Задание 14.Action — выполнение действия(!!)
            //Условие
            //Создайте Action<string> для вывода строки в консоль в верхнем регистре.

            //Требуется:
            //Передать строку
            //Вывести результат через Action

            //Action<string> showInUpper = (str) => Console.WriteLine(str.ToUpper());

            //*********************************************************************//

            //Задание 15.Func с несколькими параметрами(!!)
            //Условие
            //Создайте Func<double, double, double> — вычисление среднего арифметического двух чисел.

            //Требуется:
            //Передать два числа
            //Получить результат
            //Вывести результат

            //Func<double, double, double> calcAverage = (a, b) => (a + b) / 2;
        }
    }
}
