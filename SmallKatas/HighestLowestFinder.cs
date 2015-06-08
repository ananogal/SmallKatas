using System;
using System.Linq;

namespace SmallKatas
{
	public class HighestLowestFinder
	{
		public string Find(string numbers)
		{
			var listOfNumbers = numbers.Split(' ').Select(x => int.Parse(x)).ToArray();

			Array.Sort(listOfNumbers);
			var result = listOfNumbers.Last().ToString() + " " + listOfNumbers.First().ToString(); 

			return result;
		}
	}

}

