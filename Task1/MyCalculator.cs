using System;
namespace Task1
{
	public class MyCalculator : ICalculator
	{
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

