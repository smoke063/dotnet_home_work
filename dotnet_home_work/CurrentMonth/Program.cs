using System;

namespace CurrentMonth
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текущего месяца: ");

            if (int.TryParse(Console.ReadLine().Trim(), out var currentMonth) == false)
            {
                Console.WriteLine("Вы ввели некорректные данные! До свидание!");
                Console.ReadKey();
                return;
            }

            if (DateTime.Today.Month != currentMonth)
            {
                Console.WriteLine("Вы ввели не текущий месяц !!! До свидание!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(new DateTime(DateTime.Today.Year, currentMonth, 1).ToString("MMMM"));
            Console.ReadKey();
        }
    }
}