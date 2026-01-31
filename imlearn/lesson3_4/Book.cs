namespace lesson3_4
{
    //9.Книга(!!)
    //Создайте класс Book с автосвойствами : Title, Author, Year, Pages.Добавьте:
    //конструктор
    //метод GetInfo() → "Ядро и IPS (Л.Н. Лазарев, 1869)"

    public class Book
    {
        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public int Year { get; set; }

        public int Pages { get; set; }

        public Book(string title, string author, int year, int pages) 
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        public string GetInfo()
        {
            return $"{Title} ({Author}, {Year})";
        }
    }
}
