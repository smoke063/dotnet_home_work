using System;
using System.IO;
using System.Linq;

namespace BinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите набор чисел (0...255):");
            try
            {
                var numbers = Console.ReadLine().Trim().Split(" ").Select(i => int.Parse(i));
                const string fileName = "Test.dat";
                using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
                {
                    foreach (var n in numbers)
                    {
                        writer.Write(n);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
        }
    }
}
