namespace lesson3_4
{
    //10.Студент
    //Класс Student с автосвойствами Name, Group, Gpa (средний балл). Добавьте метод IsExcellent() → true, если Gpa >= 4.5.

    public class Student
    {
        public string Name { get; set; } = string.Empty;

        public string Group { get; set; } = string.Empty;

        public double Gpa { get; set; }

        public bool IsExellent()
        {
            return Gpa >= 4.5;
        }
    }
}
