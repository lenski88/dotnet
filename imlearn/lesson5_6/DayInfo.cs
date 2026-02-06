//Задача 2: День
//Создай структуру DayInfo:
//Day(int) свойство
//Month(int) свойство
//метод IsValid(), который проверяет, что день от 1 до 31, месяц от 1 до 12

namespace lesson5_6
{
    class DayInfo
    {
        public int Day { get; set; }

        public int Month { get; set; }

        public bool IsValid()
        {
            return Day is >= 1 and <= 31 && Month is >= 1 and <= 12;
        }
    }
}
