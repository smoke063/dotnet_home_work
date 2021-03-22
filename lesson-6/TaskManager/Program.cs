using System;
using System.Diagnostics;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1 && args[0] == "-d")
            {
                DisplayProccessList();
                return;
            }

            if (args.Length == 2 && args[0] == "-k")
            {
                int id;
                if (int.TryParse(args[1], out id))
                {
                    Process.GetProcessById(id).Kill();
                    return;
                }

                var pr = Process.GetProcessesByName(args[1]);
                foreach (var process in pr)
                {
                    process.Kill();
                }
            }
        }

        static void DisplayProccessList()
        {
            Console.WriteLine("{0,-10} {1,30}\n", "Id", "Process Name");
            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    Console.WriteLine("{0,-10} {1,30}", process.Id, process.ProcessName);
                }
                catch (System.InvalidOperationException)
                {
                    continue;
                }
                catch (System.ComponentModel.Win32Exception exc)
                {
                    continue;
                }
            }
        }
    }
}
