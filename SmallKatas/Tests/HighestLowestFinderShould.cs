using System;
using NUnit.Framework;
using SmallKatas;

namespace Tests
{
	[TestFixture]
	public class HighestLowestFinderShould
	{
		[TestCase("1 2 3 4 5", "5 1")]
		[TestCase("1 2 -3 4 5", "5 -3")]
		[TestCase("1 9 3 4 -5", "9 -5")]
		public void findTheHighestAndLowestNumberOfAGivenString(string start, string expected)
		{
			var highestLowestFinder = new HighestLowestFinder();

			Assert.AreEqual(highestLowestFinder.Find(start), expected);
		}
	}
}