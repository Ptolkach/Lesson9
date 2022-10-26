using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветсвует калькулятор!");
                Console.WriteLine("Введите первое число");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите операцию ( *  /  +  - )");
                string[] array = { "*", "/", "+", "-" };
                string op = Console.ReadLine();

                try
                {
                    if (!array.Contains(op))
                    {
                        throw new Exception("Не верно указана операция");
                    }
                    if (op == "*")
                    {
                        Console.WriteLine($"Результат: {a} * {b} = {a * b}");
                    }
                    else if (op == "/")
                    {
                        Console.WriteLine($"Результат: {a} / {b} = {a / b}");
                    }
                    else if (op == "+")
                    {
                        Console.WriteLine($"Результат: {a} + {b} = {a + b}");
                    }
                    else
                    {
                        Console.WriteLine($"Результат: {a} - {b} = {a - b}");
                    }
                }
                catch (DivideByZeroException ex) when (op == "/" && b == 0)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

    }
}
