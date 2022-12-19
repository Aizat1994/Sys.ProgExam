using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ItStep
{
    internal class Proces
    {
        public static async void AllProces()
        {

            foreach (Process process1 in Process.GetProcesses())
            {
                Console.WriteLine($" | ID: {process1.Id} | Name: {process1.ProcessName} | Virtual memory size:{process1.VirtualMemorySize64} |");
            }
        }

        public static async void Proces_Chrome() 
        {
            foreach (Process process1 in Process.GetProcessesByName("chrome"))
            {
                Console.WriteLine($" | ID: {process1.Id} | Name: {process1.ProcessName} | Virtual memory size:{process1.VirtualMemorySize64} |");
            }
        }
        public static async void Menu()
        {
            Console.WriteLine("Выберите оцию\n1. покозать все процессы\n2. покозать все процессы chrome\nили enter выход");
            string userKey = Console.ReadLine();
            switch (userKey)
            {
                case "1":
                    AllProces();
                    break;
                case "2":
                    Proces_Chrome();
                    break;
                default:
                    Console.WriteLine("выход");
                    break;
            }
        }

    }
}
