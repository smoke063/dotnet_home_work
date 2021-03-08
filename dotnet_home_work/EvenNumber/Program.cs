using System;
using System.Globalization;

namespace EvenNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число: ");

            try
            {
                var number = float.Parse(Console.ReadLine().Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                var intNumber = (int) number;
                Console.WriteLine("Result: " + intNumber);
                if (intNumber % 2 == 0)
                    Console.WriteLine("Число является четным!");
                else
                    Console.WriteLine("Число является нечетным!");

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Вы ввели не корректное число! До свидание.");
                Console.WriteLine(e.Message);
            }
        }
    }
}