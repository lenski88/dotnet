
//Создайте 2 класса и реализуйте у них метод Save::
//FileStorage → выводит "Данные сохранены в файл"

//MemoryStorage → выводит "Данные сохранены в память"
namespace lesson5_6
{
    class FileStorage : IStorage
    {
        public void Save(string data)
        {
            Console.WriteLine("Данные сохранены в файл");
        }
    }

    class MemoryStorage : IStorage
    {
        public void Save(string data)
        {
            Console.WriteLine("Данные сохранены в память");
        }
    }
}
