using System;

namespace PartsOfYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер мес: ");
           var month = Console.ReadLine().Trim();
       
           Console.WriteLine(GetSeason(Int32.Parse(month)));
        }

        static string GetSeason(int myValue)
        {
            var message = myValue switch
            {
                int value when value > 0 && value <= 2 || value == 12 => "Зима",
                int value when value > 2 && value <= 5  => "Весна",
                int value when value > 5 && value <= 8  => "Лето",
                int value when value > 8 && value <= 11  => "Осень",
                _ => "Ошибка: введите число от 1 до 12"
            };
            return message;
        }
    }
}
