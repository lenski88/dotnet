//Задача 4: Калькулятор(!!)
//Создай статический класс MathHelper c методами:
//static Add(int a, int b)

//static Subtract(int a, int b)

//static Multiply(int a, int b)
//Напишите реализацию методов и проверьте на работоспособность

namespace lesson5_6
{
    static class MathHelper
    {
        public static int Add(int a, int b) => a + b;

        public static int Subtract(int a, int b) => a - b;

        public static int Multiply(int a, int b) => a * b;
    }
}
