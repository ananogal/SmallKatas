using System;
using NUnit.Framework;
using SmallKatas;
using FluentAssertions;

namespace Tests
{
	[TestFixture]
	public class CompareSquaresShould
	{
		[TestCase(new int[]{121, 144, 19, 161, 19, 144, 19, 11 }, new int[]{121, 14641, 20736, 361, 25921, 361, 20736, 361}, true)]
		[TestCase(new int[]{121, 144, 19, 161, 19, 144, 19, 11 }, new int[]{132, 14641, 20736, 361, 25921, 361, 20736, 361}, false)]
		[TestCase(null, new int[]{132, 14641, 20736, 361, 25921, 361, 20736, 361}, false)]
		[TestCase(new int[]{121, 144, 19, 161, 19, 144, 19, 11 }, null, false)]
		public void BeTrueWhenSecondArrayHasTheSquaresOfFirstArray(int[] first, int[] second, bool expected)
		{
			var compareSquares = new CompareSquares();
			compareSquares.Compare(first, second).Should().Be(expected);
		}
	}
}

