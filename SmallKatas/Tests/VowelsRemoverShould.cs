using System;
using NUnit.Framework;
using SmallKatas;
using FluentAssertions;

namespace Tests
{
	[TestFixture]
	public class VowelsFinderShould
	{
		[Test]
		public void FindAndRemoveAllVowelsFromASentence()
		{
			var finder = new VowelsFinder();

			var expected = "Ths wbst s fr lsrs LL!"; 

			finder.Remove("This website is for losers LOL!").Should().Be(expected);
		}
	}
}

