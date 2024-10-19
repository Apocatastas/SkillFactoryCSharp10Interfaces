using System;
using System.Text.RegularExpressions;

namespace Task2
{
    /// ✓ Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
    /// ✓ Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.

    class Program
    {
        static ILogger Logger { get; set; }

        public static int GetArgument()
        {
            string pattern = "^[0-9]*$";
            string input_result = string.Empty;
            bool success = false;
            int result = 0;

            while (success == false)
            {
                Console.WriteLine("Введите число: ");
                input_result = Console.ReadLine();
                if (!Regex.IsMatch(input_result, pattern))
                {
                    Logger.Error("Вы ввели что-то непохожее на число, попробуйте ещё раз!\n");
                }
                else
                {
                    try
                    {
                        result = Convert.ToInt32(input_result);
                        
                        Logger.Event("Аргумент успешно распознан");
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        success = false;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Logger = new Logger();
            MyCalculator calculator = new MyCalculator(Logger);
            int argA = GetArgument();
            int argB = GetArgument();
            int result_calc = calculator.Plus(argA, argB);
            Logger.Event("Результат вычислен успешно");
            Console.Write("{0} + {1} = {2}", argA, argB, result_calc);
            Console.ReadKey();
        }
    }
}