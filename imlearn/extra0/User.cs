//14.Частичные классы(Partial Classes)
//Разделите определение класса User на два разных файла (или две части в одном файле для теста):
//В первой части объявите свойства: Id, Name, Email.
//Во второй части объявите метод ValidateEmail(), который проверяет наличие символа '@' в поле Email.
//Убедитесь, что компилятор видит класс как единое целое, и вызовите метод валидации из метода Main.

namespace extra0
{
    partial class User(long id, string name, string email)
    {
        public long Id { get; init; } = id;
            
        public string Name { get; init; } = name;

        public string Email { get; init; } = email;
    }

    partial class User
    {
        public bool ValidateEmail()
        {
            return Email.Contains('@');
        }
    }
}
