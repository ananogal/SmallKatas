using System;
using NUnit.Framework;
using SmallKatas;
using FluentAssertions;

namespace Tests
{
	[TestFixture]
	public class ArrayPlusOneShould
	{
		[TestCase(new int[]{ 9, 9}, new int[]{ 1, 0, 0 })]
		[TestCase(new int[]{ 2, 3, 9 }, new int[]{ 2, 4, 0 })]
		[TestCase(new int[]{ 4, 3, 2, 5 }, new int[]{ 4, 3, 2, 6})]	
		[TestCase(new int[]{9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7}, new int[]{9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 8})]
		[TestCase(new int[]{ 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 1}, 
		          new int[]{ 9, 2, 2, 3, 3, 7, 2, 0, 3, 6, 8, 5, 4, 7, 7, 5, 8, 0, 7, 5, 3, 2, 6, 7, 8, 4, 2, 4, 2, 6, 7, 8, 7, 4, 5, 2, 2})]
		public void AddOneToTheIntRepresentationOfItsElements(int[] startingArray, int[] expected)
		{
			var arrayPlusOne = new ArrayPlusOne();
			var result = arrayPlusOne.AddOne(startingArray);

			result.Should().Equal(expected);
		}

		[TestCase(new int[]{ 1, 2, 34})]
		[TestCase(new int[]{ 2, -3, 9})] 
		[TestCase(new int[]{})] 
		public void ReturnNullForNegativeNumbersEmptyArrayAndNumbersGreaterThanNine(int[] startingArray)
		{
			var arrayPlusOne = new ArrayPlusOne();
			var result = arrayPlusOne.AddOne(startingArray);

			result.Should().BeNull();
		}
	}
}

