//Задача 7: Наследование - Транспорт(!!)

//Создайте базовый класс Transport


//Свойства: Speed, Name
//Метод Move(), который выводит:
// "Транспорт движется"

//Создайте производные классы:
//Car
//Bicycle
//Переопределите  Move():
//Машина: "Машина едет со скоростью X"
//Велосипед: "Велосипед едет со скоростью X"
namespace lesson5_6
{
    class Transport(string name)
    {
        public string Name { get; init; } = name;

        public int Speed { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"Транспорт движется");
        }
    }

    class Car(string name) : Transport(name)
    {
        public override void Move()
        {
            Console.WriteLine($"Машина едет со скоростью {Speed}");
        }
    }

    class Bicycle(string name) : Transport(name)
    {
        public override void Move()
        {
            Console.WriteLine($"Велосипед едет со скоростью {Speed}");
        }
    }

}
