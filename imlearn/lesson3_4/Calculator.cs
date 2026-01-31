namespace lesson3_4
{
    //12.Класс Calculator(!!)
    //Реализуйте перегруженные методы Multiply:
    //int Multiply(int a, int b)
    //double Multiply(double a, double b)
    //int Multiply(int a, int b, int c) — произведение трёх чисел

    public static class Calculator
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}
