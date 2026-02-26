//6.Классы
//Создайте класс Book со свойствами: Title(string), Author(string), Year(int), IsAvailable(bool).
//Реализуйте конструктор, который инициализирует все поля.
//Добавьте метод Borrow(), который меняет IsAvailable на false, если книга доступна, и выбрасывает исключение или выводит сообщение, если нет.
//(Насчет исключений нужно будет самим почитать как их генерить)
//Добавьте метод Return(), который возвращает книгу в библиотеку.
//Создайте несколько экземпляров и протестируйте логику выдачи и возврата.


namespace extra0
{
    class Book(string title, string author, int year)
    {
        public string Title { get; init; } = title;

        public string Author { get; init; } = author;

        public int Year { get; init; } = year;

        public bool IsAvailable { get; set; }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
            } 
            else 
            {
                throw new Exception("Книга недоступна");
            }
        }

        public void Return()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
            }
        }
    }
}
