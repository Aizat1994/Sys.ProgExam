using ItStep;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ItStep
{
    class Program
    {

        

        static void Main()
        {
            // CalcPanel calcPanel = new CalcPanel();
            //calcPanel.Calculate();
            // Proces proces = new Proces();

            //Sborka.SborkaALL();
            //ImageThread imageThread = new ImageThread();
            //imageThread.ImageThread1();
            // Console.ReadLine();
            //CarsPlinQ.PrintCars();
            //Paralel.Paralelnoe();
            //Console.ReadLine();
            while (true)
            {
                string menu = "Главное меню\n1. Калькулятор\n2. Процессы\n3. Сборка\n4. Регистер\n5. Потоки\n6. PLinQ машины\n7. Паралельность\n Пустая строка и Enter, чтобы выйти\n";
                Console.Write(menu);
                string userKey = Console.ReadLine();
                switch (userKey)
                {
                    case "1":
                        CalcPanel.Calculate();
                        break;
                    case "2":
                        Proces.Menu();
                        break;
                    case "3":
                        Sborka.SborkaALL();
                        break;
                    case "4":
                        Rega.Menu();
                        break;
                    case "5":
                        ImageThread.ImageThread1();
                        break;
                    case "6":
                        CarsPlinQ.PrintCars();
                        break;
                    case "7":
                        Paralel.Paralelnoe();
                        break;
                    default:
                        return;


                }
            }
        }
    }

    
}
