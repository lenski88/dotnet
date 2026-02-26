//4.Методы
//Создайте статический класс MathUtils. Реализуйте в нем метод с именем Calculate, который использует именованные и необязательные параметры.
//Метод должен принимать два числа a и b, а также параметр операции operation (можете string сделать можете enum как комфортно).
//В зависимости от операции (например "sum", "sub", "mul", "div") метод возвращает результат. Продемонстрируйте вызов метода..

namespace extra0
{
    static class MathUtils
    {
        public static double Calculate(double a, double b, Operations operation = Operations.Sum)
        {
            return operation switch
            {
                Operations.Sum => a + b,
                Operations.Sub => a - b,
                Operations.Mul => a * b,
                Operations.Div => a / b,
                _ => 0
            };
        }  
    }

    enum Operations
    {
        Sum,
        Sub,
        Mul,
        Div
    }
}
