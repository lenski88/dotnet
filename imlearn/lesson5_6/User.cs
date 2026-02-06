

//Задача 3: Счётчик объектов
//Создай класс User:
//статическое поле TotalUsers
//при создании каждого нового объекта User счётчик увеличивается

//Создайте 3-4  пользователя и выведите TotalUsers
namespace lesson5_6
{
    class User
    {
        public static int TotalUsers;

        public User()
        {
            TotalUsers++;
        }
    }
}
