using System;
using System.Linq;

namespace NumbersSeparatedBySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine()?.Trim();
            Console.WriteLine(ConvertStringNumbersToSumNumber(str));
        }

        static int ConvertStringNumbersToSumNumber(string str = "")
        {
            int sum = 0;
            foreach (var c in str.ToCharArray())
            {
                if (!Char.IsWhiteSpace(c))
                {
                    int number;
                    if (int.TryParse(c.ToString(), out number))
                    {
                        sum += number;
                    }
                }
            }
            return sum;
        }
    }
}
