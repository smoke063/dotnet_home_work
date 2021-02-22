using System;
using System.Diagnostics;

namespace lesson_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            var name = Console.ReadLine();
            while (true)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
                    Console.ReadKey();
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(
                    "Вы ввели пустое имя пользователя! Введите имя пользователя заново или нажмите Enter для выхода завершения программмы:");
                Console.ForegroundColor = ConsoleColor.White;
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    Environment.Exit(0);
            }
        }
    }
}