using System;
using NUnit.Framework;
using FluentAssertions;
using SmallKatas;

namespace Tests
{
	[TestFixture]
	public class DirectionReducerShould
	{
		[TestCase(new string[] {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"}, new string[] {"WEST"})]
		[TestCase(new string[] {"NORTH", "WEST", "SOUTH", "EAST"}, new string[] {"NORTH", "WEST", "SOUTH", "EAST"})]
		[TestCase(new string[] {"NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST"}, new string[]{"WEST", "WEST"})]
		[TestCase(new string[] {"NORTH", "SOUTH", "NORTH", "WEST", "WEST", "WEST"}, new string[]{"NORTH", "WEST", "WEST", "WEST"})]
		[TestCase(new string[] {"NORTH", "SOUTH", "NORTH", "WEST", "SOUTH", "EAST", "NORTH", "SOUTH", "SOUTH", "NORTH"}, 
		          new string[]{"NORTH", "WEST", "SOUTH", "EAST"})]
		[TestCase(new string[]{"NORTH", "SOUTH", "EAST", "WEST"}, new string[]{})]
		public void ReduceToTheCorrectDirections(string[] directions, string[] expected)
		{
			var directionReducer = new DirectionReducer();

			directionReducer.Reduce(directions).Should().Equal(expected);
		}
	}
}

