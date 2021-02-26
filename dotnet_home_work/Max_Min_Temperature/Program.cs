using System;

namespace Max_Min_Temperature
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру:");
            if (int.TryParse(Console.ReadLine().Trim(), out var minTemperature) == false)
            {
                Console.WriteLine("Вы ввели некорректные данные. Введите минимальную температуру:");
                if (int.TryParse(Console.ReadLine().Trim(), out minTemperature) == false)
                {
                    Console.WriteLine("Вы ввели некорректные данные! До свидание!");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("Введите максимальную температуру:");
            if (int.TryParse(Console.ReadLine().Trim(), out var maxTemperature) == false)
            {
                Console.WriteLine("Вы ввели некорректные данные. Введите максимальную температуру:");
                if (int.TryParse(Console.ReadLine().Trim(), out maxTemperature) == false)
                {
                    Console.WriteLine("Вы ввели некорректные данные! До свидание!");
                    Console.ReadKey();
                    return;
                }
            }

            int middleTemperature = (minTemperature + maxTemperature) / 2;
            Console.WriteLine("Среднесуточную температура: " + middleTemperature);
            Console.ReadKey();
        }
    }
}