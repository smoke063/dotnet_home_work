using System;
using System.IO;

namespace SaveDataToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные: ");
            string text = Console.ReadLine();

            File.WriteAllText("WriteText.txt", text);
        }
    }
}
