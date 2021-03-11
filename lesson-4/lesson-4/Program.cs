using System;

namespace lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
           Print(GetFullName("Вася", "Васильев", "Александрийский"));
           Print(GetFullName("Антон", "Хан", "Батыровский"));
           Print(GetFullName("Леся", "Прохоров", "Махмудовский"));
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $@"{firstName} {lastName} {patronymic}";
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
