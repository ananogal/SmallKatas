using System;
using NUnit.Framework;
using SmallKatas;
using FluentAssertions;

namespace Tests
{
	[TestFixture]
	public class CapitalsFinderShould
	{
		[Test]
		public void ShowIndexOfCapitalLetters()
		{
			var finder = new CapitalsFinder();
			var expected = new int[]{ 0, 4, 6, 7, 13, 17 };

			finder.FindIndexes("ThisIsAStringWithCapitals").Should().Equal(expected);
		}
	}
}

