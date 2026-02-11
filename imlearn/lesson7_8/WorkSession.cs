//Задача 2. TimeSpan(!!) 

// Создайте класс WorkSession:
//StartTime(DateTime)
//EndTime(DateTime)

//Требуется:
//вычислить длительность сессии при вызове отдельного метода который вы объявите в рамках класса WorkSession
//второй метод пускай выводит тоже длительность времени но в формате (часы и минуты) Пример: Сессия продлилась: “154 часа и 14 минут”

namespace lesson7_8
{
    class WorkSession
    {
        public DateTime StartTime { get; }

        public DateTime EndTime { get; }

        public WorkSession(DateTime startTime, DateTime endTime)
        {
            if (endTime > DateTime.Now || endTime < startTime)
            {
                throw new ArgumentException();
            }

            StartTime = startTime;
            EndTime = endTime;
        }

        public TimeSpan GetDuration()
        {
            return EndTime.Subtract(StartTime);
        }

        public override string ToString()
        {
            TimeSpan duration = GetDuration();

            int tm = (int)Math.Round(duration.TotalMinutes);

            int h = tm / 60;
            int m = tm % 60;

            return $"Сессия продлилась {h} ч. и {m} мин.";
        }
    }
}
