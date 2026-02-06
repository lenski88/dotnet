//Задача 6: Инкапсуляция - Счётчик шагов(!!)
//Создайте класс StepCounter
//Закрытое поле steps

//Публичные методы:

//AddSteps(int count) чтобы добавить шаги

//если count <= 0, шаги не добавляются

//Reset() чтобы обнулить шаги

//GetSteps() возвращает текущее количество шагов

//Запретите прямой доступ к полю steps
namespace lesson5_6
{
    class StepCounter
    {
        private int steps;

        public void AddSteps(int count)
        {
            if (count > 0)
            {
                steps += count;
            }
        }

        public void Reset()
        {
            steps = 0;
        }

        public int GetSteps()
        {
            return steps;
        }
    }
}
