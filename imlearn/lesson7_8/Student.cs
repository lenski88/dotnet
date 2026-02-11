//Задача 3. List(!!) 

// Создайте класс Student со свойствами:
//Guid(Guid)
//Name(string)
//Grade(int)

//Создайте List<Student>.
//Требуется:
//добавить минимум 5 студентов в Main

// Написать отдельный метод, который будет выводить всех студентов с оценкой ≥ 4

namespace lesson7_8
{
    class Student(string name, int grade)
    {
        public Guid Guid { get; } = new();

        public string Name { get; } = name;

        public int Grade { get; set; } = grade;

        public override string ToString()
        {
            return $"Name: {Name}; Grade: {Grade}";
        }
    }
}
