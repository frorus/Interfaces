using System;
using System.Linq;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result = 0;
            string[] arrayOfOperations = new string[] { "*", "-", "+", "/" };
            BaseCalculator baseCalculator = new();
            Logger logger = new();

            logger.Event("Введите два числа для расчета: ");

            while (true)
            {
                try
                {
                    logger.Event("Первое число");
                    num1 = baseCalculator.ReadNumber();

                    logger.Event("Второе число");
                    num2 = baseCalculator.ReadNumber();

                    logger.Event("Введите математическое действие (*, -, +, /):");
                    string operation = Console.ReadLine();

                    while (arrayOfOperations.Contains(operation) == false)
                    {
                        logger.Error("Ввод некорректный, попробуйте еще раз");
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
                            else
                            {
                                result = baseCalculator.Division(num1, num2);
                            }
                            break;
                    }

                    logger.Event("\nРезультат:");
                    Console.WriteLine(result);
                    Console.WriteLine();
                }
                catch (FormatException)
                {

                    logger.Error("Число введено некорректно");
                }

                catch (DivideByZeroException)
                {

                    logger.Error("На ноль делить нельзя");
                }

                catch (OverflowException)
                {

                    logger.Error("Число слишком большое");
                }

                catch (Exception ex)
                {
                    logger.Error("Неизвестная ошибка:");
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
