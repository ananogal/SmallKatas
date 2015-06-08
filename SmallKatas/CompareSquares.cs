using System;
using System.Linq;
using System.Collections.Generic;

namespace SmallKatas
{
	public class CompareSquares
	{
		public bool Compare(int[] first, int[] second)
		{
			if(first == null || second == null)
			{
				return false;
			}

			var numbersFounded = second.Select(x => first.Where(f => x == f*f).FirstOrDefault()).ToArray(); 
			Array.Sort(numbersFounded);
			Array.Sort(first);

			if(numbersFounded.SequenceEqual(first))
			{
				return true;
			}
			return false;
		}
	}

}

