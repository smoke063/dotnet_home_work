using System;
using System.Runtime.CompilerServices;

namespace phone_book
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var phoneBook = new string[5, 2];
            for (var i = 0; i < phoneBook.GetLength(0); i++)
            {
                Console.Write("Введите имя контакта: ");
                phoneBook[i, 0] = Console.ReadLine().Trim();
                Console.Write("Введите телефон: ");
                phoneBook[i, 1] = Console.ReadLine().Trim();
            }

            Console.WriteLine();
            Console.WriteLine("Вы заполнили телефонный справочник следующими значениями: ");
            Print(phoneBook);
            Console.ReadKey();
        }

        private static void Print(string[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j]} ");

                Console.WriteLine();
            }
        }
    }
}