//Задание 3. Асинхронность

//Небольшая теория перед задачей. Task.WhenAll =  "Ждёт, пока все закончат".
//Task.WhenAny  =  "Ждёт, пока хоть кто-то закончит".

//Создайте метод Task<string> GetDataAsync(string sourceName, int delayMs).
//Внутри: await Task.Delay(delayMs).
//Возвращает строку "Данные от {sourceName}".
//В Main запустите две задачи:
//Задача А: задержка 3000 мс.(Task.Delay)
//Задача Б: задержка 1000 мс.(Task.Delay)
//Используйте await Task.WhenAny(taskA, taskB), чтобы получить задачу, которая завершилась первой.
//Выведите результат только победившей задачи.

namespace lesson11
{
    static class AsyncHelper
    {
        public static async Task<string> GetDataAsync(string sourceName, int delayMs)
        {
            await Task.Delay(delayMs);

            return $"Данные от {sourceName}";
        }
    }
}
