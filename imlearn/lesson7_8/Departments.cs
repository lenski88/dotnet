//Задача 5. Dictionary + LIst (!!)

//Создайте класс Department:
//Id(int)
//Name(string)

//Создайте Создайте Dictionary<int, List<Employee>>, где:
//ключ — Id отдела
//значение — список сотрудников этого отдела

//Класс Employee:
//Id(int)
//Name(string)

//Требуется:
//добавить сотрудников в разные отделы

//по Id отдела вывести список сотрудников через foreach

namespace lesson7_8
{
    class Department(int id, string name)
    {
        public int Id { get; } = id;

        public string Name { get; } = name;
    }

    class Employee(string name)
    {
        public int Id { get; } = new Random().Next();

        public string Name { get; } = name;
    }
}
