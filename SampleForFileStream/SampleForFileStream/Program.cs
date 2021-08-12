using System;
using System.IO;

namespace SampleForFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = Path.Combine("D:", "Курсы.Net", "SemplesFor.Net", "SampleForFileStream", "TestFiles");
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            Console.WriteLine("Введите текст");
            var text = Console.ReadLine();

            using (FileStream fileStream = new FileStream($"{path}\\test.txt", FileMode.Append))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fileStream.Write(array, 0, array.Length);
            }

            using (FileStream fileStream = new FileStream($"{path}\\test.txt",FileMode.Open))
            {
                byte[] array2 = new byte[fileStream.Length];
                fileStream.Read(array2, 0, array2.Length);
                string readText = System.Text.Encoding.Default.GetString(array2);
                Console.WriteLine(readText);
            }
        }
    }
}
