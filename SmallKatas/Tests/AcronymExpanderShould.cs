using System;
using NUnit.Framework;
using SmallKatas;

namespace Tests
{
	[TestFixture]
	public class AcronymExpanderShould
	{
		[TestCase("lol", "laugh out loud")]
		[TestCase("dw", "don't worry")]
		[TestCase("gl hf all", "good luck have fun all")]
		public void ExpandTheAcronym(string acronym, string expected)
		{
			var acronymExpander = new AcronymExpander();
			var result = acronymExpander.Expand(acronym);

			Assert.AreEqual(expected, result);
		}
	}
}