using System;
namespace Task2
{
	public class Logger : ILogger
	{
		public Logger()
		{

		}

		public void Event(string message)
		{
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

		public void Error(string message)
		{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
	}
}

