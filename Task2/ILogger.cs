using System;
namespace Task2
{
	public interface ILogger
	{
		public void Event(string message);
		public void Error(string message);
	}
}

