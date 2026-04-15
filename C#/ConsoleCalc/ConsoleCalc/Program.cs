using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0; double num2 = 0;  String inpu = "";
            Console.WriteLine("Консольный калькулятор на C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Выберте действие ");
          

            Console.WriteLine("\ta - Сложение");
            Console.WriteLine("\tb - Вычитание");
            Console.WriteLine("\tc - Умножение");
            Console.WriteLine("\td - Деление");
            Console.WriteLine("\tf - Возведение в степень ");

            inpu = Console.ReadLine();
            if (inpu == "f")
            {
                Console.WriteLine("Число, которое возводится в степень");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("степень, в которую возводится ");
                num2 = Convert.ToDouble(Console.ReadLine());


            }
            else
            {
             Console.WriteLine("Введите число и нажмите Enter");
             num1 = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите еще один номер и нажмите Enter");
             num2 = Convert.ToDouble(Console.ReadLine());
            }


            switch (inpu)
            {
                case "a":
                    Console.WriteLine($"Результат: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "b":
                    Console.WriteLine($"Результат: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "c":
                    Console.WriteLine($"Результат: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Результат: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "f":
                    Console.WriteLine($"Результат: {num1} ^ {num2} = " + Math.Pow(num1, num2));
                    break;

            }
            Console.Write("Нажмите любую клавишу, чтобы закрыть приложение «Консольный калькулятор»");
            Console.ReadKey();

        }
    }
}
