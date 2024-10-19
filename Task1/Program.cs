
using System;
using System.Text.RegularExpressions;

namespace Task1
{

    /// ✓ Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел.
    /// ✓ Определите интерфейс для функции сложения числа и реализуйте его.
    /// ✓ Дополнительно: добавьте конструкцию Try / Catch / Finally для проверки
    ///     корректности введённого значения.
    ///

    class Program
    {
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
                    Console.Write("Вы ввели что-то непохожее на число, попробуйте ещё раз!\n");
                }
                else
                {
                    try
                    {
                        result = Convert.ToInt32(input_result);
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
            MyCalculator calculator = new MyCalculator();
            int argA = GetArgument();
            int argB = GetArgument();
            int result_calc = calculator.Plus(argA, argB);
            Console.Write("{0} + {1} = {2}", argA,argB,result_calc);
            Console.ReadKey();
        }
    }
}