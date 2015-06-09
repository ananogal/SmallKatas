using System;
using NUnit.Framework;
using SmallKatas;

namespace Tests
{
	[TestFixture]
	public class FactorialCalculatorShould
	{
		[TestCase(0, 1)]
		[TestCase(5, 120)]
		public void CalculateTheFactorialOfANumberMinorThan12(int factorial, int expected)
		{
			var calculator = new FactorialCalculator();

			var result = calculator.Calculate(factorial);

			Assert.AreEqual(expected, result);
		}

		[ExpectedException( typeof( ArgumentOutOfRangeException ) )]
		[TestCase(-2, 1)]
		[TestCase(13, 1)]
		public void ThrowAOutOfRangeExceptionIfFactorialIsNegativeOrGreaterThan12(int factorial, int expected)
		{
			var calculator = new FactorialCalculator();

			var result = calculator.Calculate(factorial);

			Assert.AreEqual(expected, result);
		}
	}
}

