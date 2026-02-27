//Задание 1. Record (Записи)
//Создайте public record Employee с позиционными параметрами: string Name, int Id, string Department.
//В Main создайте два объекта сотрудника с одинаковыми данными.
//Сравните их через == и через .Equals(). Выведите результат в консоль.

namespace lesson11
{
    record Employee(string Name, int Id, string Department, decimal Salary);
}
