using System;
using System.Linq;

namespace Hello_revers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            var chars = Console.ReadLine().Trim().Reverse().ToArray();
            Console.WriteLine("Обратная строка: " + new string(chars));
        }
    }
}