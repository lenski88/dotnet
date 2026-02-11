using System.Collections;
using System.Collections.Generic;

namespace lesson7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Student> sl = new()
            //{
            //    new Student("s0", 2),
            //    new Student("s1", 5),
            //    new Student("s2", 3),
            //    new Student("s3", 2),
            //    new Student("s4", 6)
            //};

            //ShowSuccessfullStudents(sl);

            //***********************************************//

            //Dictionary<int, Book> bd = new Dictionary<int, Book>();

            //bd.TryAdd(0, new Book(0, "t0", "a0"));
            //bd.TryAdd(1, new Book(0, "t1", "a1"));
            //bd.TryAdd(2, new Book(0, "t2", "a2"));
            //bd.TryAdd(3, new Book(0, "t3", "a3"));

            //bd.TryGetValue(3, out var b);

            //if (b != null)
            //{
            //    Console.WriteLine($"Title: : {b.Title}; Author: {b.Author}");
            //}

            //***********************************************//

            //Dictionary<int, List<Employee>> led = new Dictionary<int, List<Employee>>();

            //Department d0 = new Department(0, "d0");
            //Department d1 = new Department(1, "d1");
            //Department d2 = new Department(2, "d2");

            //led.TryAdd(d0.Id, new List<Employee>()
            //{
            //    new Employee("e0"),
            //});

            //led.TryAdd(d1.Id, new List<Employee>()
            //{
            //    new Employee("e0"),
            //    new Employee("e1"),
            //});

            //led.TryAdd(d2.Id, new List<Employee>()
            //{
            //    new Employee("e0"),
            //    new Employee("e1"),
            //    new Employee("e2"),

            //});

            //foreach (var depId in led.Keys)
            //{
            //    led.TryGetValue(depId, out var employees);

            //    if (employees != null)
            //    {
            //        employees.ForEach(_ => Console.WriteLine($"Dep. Id: {depId}; Emp. Name: {_.Name}"));
            //    }
            //}

            //***********************************************//

            //Задача 6.LinkedList
            //Создайте LinkedList<string> список задач.Примеры задач :”Запуск плагина Канбан”, “Запуск редактора документво” и т.д

            //Требуется:
            //добавить задачу в начало списка
            //добавить задачу в конец списка
            //удалить первую задачу
            //вывести все оставшиеся задачи

            //LinkedList<string> tdl = new LinkedList<string>(new List<string>() { "todo0", "todo1", "todo2", });

            //tdl.AddFirst("todofirst");
            //tdl.AddLast("todolast");
            //tdl.RemoveFirst();

            //foreach (var item in tdl)
            //{
            //    Console.WriteLine(item);
            //}

            //***********************************************//

            //Queue<PrintJob> pjq = new Queue<PrintJob>();

            //pjq.Enqueue(new PrintJob("doc0", 10));
            //pjq.Enqueue(new PrintJob("doc1", 20));
            //pjq.Enqueue(new PrintJob("doc2", 30));

            //PrintJob j = pjq.Dequeue();
            //Console.WriteLine($"Печать Doc.Name: {j.DocumentName}, Pages: {j.Pages}");

            //foreach (var job in pjq)
            //{
            //    Console.WriteLine($"В очереди Doc.Name: {job.DocumentName}, Pages: {job.Pages}");
            //}

            //***********************************************//

            Stack<UserActionHistory> uahs = new Stack<UserActionHistory>();

            //uahs.Push(new UserActionHistory("action0"));
            //uahs.Push(new UserActionHistory("action1"));
            //uahs.Push(new UserActionHistory("action2"));

            //uahs.Pop();

            //foreach (var action in uahs)
            //{
            //    Console.WriteLine($"{action.ActionName}");
            //}
        }

        static void ShowSuccessfullStudents(List<Student> list)
        {
            foreach (var student in list)
            {
                if (student.Grade >= 4)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }
}
