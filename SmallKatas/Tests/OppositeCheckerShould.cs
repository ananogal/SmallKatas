using System;
using NUnit.Framework;
using SmallKatas;

namespace Tests
{
	[TestFixture]
	public class OppositeCheckerShould
	{
		[TestCase(4, 3, true)]
		[TestCase(3, 4, true)]
		[TestCase(3, 3, false)]
		public void VerifiedThePresenceOfOddAndEven(int firstNumber, int secondNumber, bool result)
		{
			var opssiteChecker = new OppositeChecker();

			Assert.AreEqual(result, opssiteChecker.checkForOddAndEvenNumbers(firstNumber, secondNumber));
		}
	}
}

