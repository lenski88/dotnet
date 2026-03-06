//Задание 2. Streams
//Научиться работать с файловой системой, читать и записывать данные, используя стримы и конструкцию using.
//Создайте в папке с проектом текстовый файл input.txt. Напишите в него несколько строк текста (например список покупок).
//Напишите программу, которая:
//Считывает содержимое input.txt с помощью StreamReader.
//Считает количество строк и количество символов в файле.
//Записывает статистику (кол-во строк и символов) в новый файл output.txt с помощью StreamWriter.
//Скопируйте само содержимое input.txt в конец output.txt.
//Важно: Обязательно используйте конструкцию using для корректного освобождения ресурсов потоков.

namespace lesson12
{
    static class FSHelper
    {
        public static async Task<string> Read(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                return await sr.ReadToEndAsync();
            }
        }

        public static async void Write(string path, string text, bool append = true)
        {
            using (StreamWriter sw = new StreamWriter(path, append))
            {
                await sw.WriteLineAsync(text);
            }
        }

        public static async void Copy(string source, string dest)
        {
            Write(dest, await Read(source));
        }

        public static async Task<FileStat> GetStat(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                int lineCount = 0;

                int charCount = 0;

                string? line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    lineCount++;

                    foreach (var _ in line)
                    {
                        charCount++;
                    }
                }

                return new FileStat(path, lineCount, charCount);
            }
        }

        public static string BuildFileStatString(FileStat fst)
        {
            return $"Путь: {fst.Path}; Строк: {fst.Lines}; Символов: {fst.Chars}";
        }
    }

    record FileStat(string Path, int Lines, int Chars);
}
