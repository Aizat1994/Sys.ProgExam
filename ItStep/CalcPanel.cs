using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ItStep
{
    internal class CalcPanel
    {
        public const string ItStep = @"C:\Users\garif\source\repos\ItStep\x64\Debug\DllItStep.dll";

        [DllImport(ItStep)]
        public static extern double plus(double a, double b);
        [DllImport(ItStep)]
        public static extern double minus(double a, double b);
        [DllImport(ItStep)]
        public static extern double multiply(double a, double b);
        [DllImport(ItStep)]
        public static extern double devision(double a, double b);


        public static async void Calculate() {

            int a = 0; int b = 0;


            Console.WriteLine(" Калькулятор  \r");
            Console.WriteLine("------------------------\n");

            
            Console.WriteLine("Введите первую цифру ");
            a = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Введите вторую цифру");
            b = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Выберите опператор действия");
            Console.WriteLine("\t+ - Плюс");
            Console.WriteLine("\t- - Минус");
            Console.WriteLine("\t* - Умножить");
            Console.WriteLine("\t/ - Делить");
            

           
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($" {a} + {b} = " + plus(a,b));
                    break;
                case "-":
                    Console.WriteLine($" {a} - {b} = " + minus(a,b));
                    break;
                case "*":
                    Console.WriteLine($" {a} * {b} = " + multiply(a, b));
                    break;
                case "/":
                    Console.WriteLine($" {a} / {b} = " + devision(a, b));
                    break;
               default:
                    Console.WriteLine($"Выход");
                break;
            }
        }
    } 
}
