//10.Статики
//Создайте класс Counter.
//Добавьте статическое поле totalCount, которое хранит общее количество созданных объектов этого класса.
//Добавьте статический конструктор, который инициализирует счетчик нулем и выводит сообщение "Counter initialized".
//Добавьте обычный конструктор, который увеличивает totalCount на 1.
//Добавьте статический метод GetTotalCount(), возвращающий текущее значение.
//Создайте 5 объектов и проверьте значение счетчика.


namespace extra0
{
    class Counter
    {
        private static int totalCount;

        static Counter()
        {
            Console.WriteLine("Counter initialized");
        }

        public Counter()
        {
            totalCount++;
        }

        public static int GetTotalCount()
        {
            return totalCount;
        }
    }
}
