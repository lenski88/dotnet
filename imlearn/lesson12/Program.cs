namespace lesson12
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Person p = new Person("person", 10, "email@expl.un", false);

            ReflectionTest.PrintProperties(p);

            string inputPath = "input.txt";

            string outputPath = "output.txt";

            FSHelper.Write(inputPath, "line1");
            FSHelper.Write(inputPath, "line2");
            FSHelper.Write(inputPath, "line3");

            FileStat fst = await FSHelper.GetStat(inputPath);

            FSHelper.Write(outputPath, FSHelper.BuildFileStatString(fst));

            FSHelper.Copy(inputPath, outputPath);
        }
    }
}
