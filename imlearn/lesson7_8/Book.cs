//Задача 4. Dictionary(!!) 

// Создайте класс Book:
//Id(int)
//Title(string)
//Author(string)


//Создайте Dictionary<int, Book>, где:
//ключ — Id
//значение — объект Book

//Требуется:
//добавить минимум 3 книги в Main(TryAdd)

//по введённому Id найти и вывести информацию о книге (используя дефолтные методы словаря) (TryGet)

namespace lesson7_8
{
    class Book(int id, string title, string author)
    {
        public int Id { get; } = id;

        public string Title { get; } = title;

        public string Author { get; } = author;
    }
}
