//8.Пространства имён(Namespaces)
//Создайте проект с двумя разными пространствами имен: Company.Developer и Company.HR.
//В каждом пространстве создайте класс с одинаковым именем Employee.
//В классе девелоперов свойство Role должно быть "Developer", в HR — "Manager".
//В методе Main создайте объекты обоих классов и решите конфликт.

namespace Company.Developer
{
    class Employee 
    {
        public object Role { get; set; } = new();
    }
}

namespace Company.HR
{
    class Employee 
    {
        public object Manager { get; set; } = new();
    }
}