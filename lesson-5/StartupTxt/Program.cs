using System;
using System.IO;

namespace StartupTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "startup.txt";
            if (!System.IO.File.Exists(file))
            {
                File.WriteAllText(file, DateTime.Now.ToString());
            }
            else
            {
                File.AppendAllText(file, $"{Environment.NewLine}{DateTime.Now.ToString()}");

            }
        }
    }
}
