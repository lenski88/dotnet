//Задание 2. Record (Записи)

//Небольшая теория перед задачей. Оператор with в связке с record создает новую копию объекта, копируя все значения из исходного объекта,
//но позволяя изменить только указанные свойства.
//Это называется недеструктивное изменение (non-destructive mutation).

//Добавьте в record Employee поле decimal Salary.
//Создайте сотрудника с зарплатой 1000.
//Напишите метод Employee Promote(Employee emp, decimal bonus), который возвращает новую запись того же сотрудника, но с увеличенной зарплатой.
//Используйте выражение with: return emp with { Salary = ... };.
//В Main убедитесь, что у старого объекта зарплата не изменилась, а у нового — изменилась.

namespace lesson11
{
    static class EmployeeHelper
    {
        public static Employee Promote(Employee emp, decimal bonus)
        {
            return emp with { Salary = emp.Salary + bonus };
        }
    }
}
