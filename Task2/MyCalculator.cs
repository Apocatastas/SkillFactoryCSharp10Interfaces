using System;
namespace Task2
{
	public class MyCalculator : ICalculator
	{
        ILogger Logger { get;  }

        public MyCalculator(ILogger logger)
        {

        }

        public int Plus(int argumentA, int argumentB)
        {
            return argumentA + argumentB;
        }

        public int Minus(int argumentA, int argumentB)
        {
            return argumentA - argumentB;
        }

        public int Multiply(int argumentA, int argumentB)
        {
            return argumentA * argumentB;
        }

	}
}

