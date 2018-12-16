using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_add__sub__mul__div
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Cоздайте проект по шаблону Console Application.  Создайте четыре метода для выполнения арифметических операций, с именами: 
            Add – сложение, Sub – вычитание, Mul – умножение, Div – деление. Каждый метод должен принимать два целочисленных аргумента и 
            выводить на экран результат выполнения арифметической операции соответствующей имени метода. Метод деления Div, должен выполнять 
            проверку попытки деления на ноль. Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак 
            арифметической операции для выполнения вычислений. */
            /*
            int num1, num2;
            char mathSign;
            Console.WriteLine("Введите два числа: ");
            int.TryParse(Console.ReadLine(), out num1);
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("Введите знак арифметической операции (+, -, *, /): ");
            char.TryParse(Console.ReadLine(), out mathSign);

            if (mathSign == '+')
                Console.WriteLine("\n{0} + {1} = {2}\n", num1, num2, Add(num1, num2));
            else if (mathSign == '-')
                Console.WriteLine("\n{0} - {1} = {2}\n", num1, num2, Sub(num1, num2));
            else if (mathSign == '*')
                Console.WriteLine("\n{0} * {1} = {2}\n", num1, num2, Mul(num1, num2));
            else if (mathSign == '/')
            {
                if (Div(num1, num2) == Mul(num1, num2))
                    Console.WriteLine("\nНа ноль делить нельзя!\n");
                else
                    Console.WriteLine("\n{0} / {1} = {2}\n", num1, num2, Div(num1, num2));
            }
            else
                Console.WriteLine("\nВы ввели неправильный знак!");
            */

            /* Напишите программу, которая будет выполнять конвертирование валют. Пользователь вводит: сумму денег в определенной валюте. Kурс для 
            конвертации в другую валюту. Организуйте вывод результата операции конвертирования валюты на экран. */
            /*
            double sum, rate;
            Console.WriteLine("Введите сумму денег: ");
            double.TryParse(Console.ReadLine(), out sum);          
            Console.WriteLine("\nВведите курс конвертации: ");
            double.TryParse(Console.ReadLine(), out rate);
            Console.WriteLine("\nСумма после конвертации = {0}", MoneyConversion(sum, rate));
            */                
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        static double Div(int num1, int num2)
        {
            if (num2 == 0)
                return num1 * num2;
            return (double)num1 / num2;
        }

        static double MoneyConversion(double sum, double rate)
        {
            return sum * rate;
        }     




    }
}
