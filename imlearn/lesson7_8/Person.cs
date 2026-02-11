//Задача 1. DateTime(!!)

//Создайте класс Person:
//Name(string)
//BirthDate(DateTime)
//Требуется:
//вывести количество полных лет при вызове отдельного метода который вы объявите в рамках класса Person

namespace lesson7_8
{
    class Person
    {
        public string Name { get; }

        public DateTime BirthDate { get; }

        public Person(string name, DateTime birthDate)
        {
            if (DateTime.Now < birthDate)
            {
                throw new ArgumentException();
            }

            Name = name;
            BirthDate = birthDate;
        }

        public double GetFullYears()
        {
            DateTime now = DateTime.Now;

            int years = now.Year - BirthDate.Year;

            return now.Month < BirthDate.Month || (now.Month == BirthDate.Month && now.Day < BirthDate.Day) 
                ? --years 
                : years;
        }
    }
}
