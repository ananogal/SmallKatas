using System;
using NUnit.Framework;
using SmallKatas;
using FluentAssertions;

namespace Tests
{
	[TestFixture]
	public class VowelsRemoverShould
	{
		[Test]
		public void FindAndRemoveAllVowelsFromASentence()
		{
			var finder = new VowelsRemover();

			var expected = "Ths wbst s fr lsrs LL!"; 

			finder.Remove("This website is for losers LOL!").Should().Be(expected);
		}
	}
}

