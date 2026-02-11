//Задача 6. Queue

//Создайте класс PrintJob:
//DocumentName(string)
//Pages(int)

//Создайте Queue<PrintJob> очередь печати.

//Требуется:
//добавить 3 задания в очередь в Main
//обработать одно задание (удалить из очереди)
//вывести оставшиеся задания в консоль

//Я вижу решение подобным образом:
//PrintJob job = queue.Dequeue();
//Console.WriteLine($"Печать документа {job.DocumentName}, страниц: {job.Pages}");

namespace lesson7_8
{
    class PrintJob(string name, int pages)
    {
        public string DocumentName { get; } = name;

        public int Pages { get; } = pages;
    }
}
