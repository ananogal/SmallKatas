using System;
using System.Linq;
using System.Collections.Generic;

namespace SmallKatas
{
	public class ArrayPlusOne
	{
		public int[] AddOne(int[] startingArray)
		{
			var negativeOrGreaterThanTenNumbers = startingArray.Where(number => (number < 0 || number > 10)).Count();
			if(negativeOrGreaterThanTenNumbers > 0  || startingArray.Count() == 0)
			{
				return null;
			}

			var invertedArray = startingArray.Reverse();

			var valueToAdd = 1;
			var listOfNumbers = new List<int>();

			foreach(var item in invertedArray)
			{
				var number = int.Parse(item.ToString());
				number += valueToAdd;

				if(number < 10)
				{
					valueToAdd = 0;
				} 
				else
				{
					number = 0;
					valueToAdd = 1;
				}
				listOfNumbers.Add(number);
			}

			if(valueToAdd == 1)
			{
				listOfNumbers.Add(valueToAdd);
			}
			var result = listOfNumbers.ToArray().Reverse();

			return result.ToArray();
		}
	}

}

