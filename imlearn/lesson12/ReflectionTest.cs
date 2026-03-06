using System.Reflection;

namespace lesson12
{
    static class ReflectionTest
    {
        public static void PrintProperties<T>(T obj)
        {
            Type type = typeof(T);

            Console.WriteLine(type.Name);

            foreach(var prop in type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public))
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
            }

        }
    }
}
