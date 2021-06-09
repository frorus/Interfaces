using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result = 0;
            string[] arrayOfOperations = new string[] { "*", "-", "+", "/" };
            BaseCalculator baseCalculator = new();

            Console.WriteLine("Введите два числа для расчета: ");

            while (true)
            {
                try
                {
                    Console.WriteLine("Первое число");
                    num1 = baseCalculator.ReadNumber();

                    Console.WriteLine("Второе число");
                    num2 = baseCalculator.ReadNumber();

                    Console.Write("Введите математическое действие (*, -, +, /):");
                    string operation = Console.ReadLine();

                    while (arrayOfOperations.Contains(operation) == false)
                    {
                        Console.Write("Ввод некорректный, попробуйте еще раз\n");
                        operation = Console.ReadLine();
                    }

                    switch (operation)
                    {
                        case "*":
                            result = baseCalculator.Multiplication(num1, num2);
                            break;

                        case "-":
                            result = baseCalculator.Subtraction(num1, num2);
                            break;

                        case "+":
                            result = baseCalculator.Sum(num1, num2);
                            break;

                        case "/":
                            if (num2 == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            else {
                                result = baseCalculator.Division(num1, num2);
                            }
                            break;
                    }

                    Console.WriteLine("\nРезультат: {0}", result);
                }
                catch (FormatException)
                {

                    Console.WriteLine("Число введено некорректно");
                }

                catch (DivideByZeroException)
                {

                    Console.WriteLine("На ноль делить нельзя");
                }

                catch (OverflowException)
                {

                    Console.WriteLine("Число слишком большое");
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Неизвестная ошибка: {0}", ex.Message);
                }
            }

        }
    }
}
