using System.Threading.Tasks;

namespace lesson11
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Employee e1 = new Employee("e1", 1, "d1", 1000);
            Employee e2 = new Employee("e1", 1, "d1", 2000);

            Console.WriteLine(e1 == e1);
            Console.WriteLine(e1.Equals(e2));

            Employee promotedEmp =  EmployeeHelper.Promote(e1, 1000);

            Console.WriteLine(e1.Salary);
            Console.WriteLine(promotedEmp.Salary);

            Console.WriteLine(await Task.WhenAny(AsyncHelper.GetDataAsync("source1", 3000), AsyncHelper.GetDataAsync("source2", 1000)).Result);
        }
    }
}
