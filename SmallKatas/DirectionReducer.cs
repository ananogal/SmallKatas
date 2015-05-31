using System;
using System.Linq;
using System.Collections.Generic;

namespace SmallKatas
{
	public class DirectionReducer
	{
		string[] northSouth = new string[] {"NORTH", "SOUTH"};
		string[] eastWest = new string[] {"EAST", "WEST"};

		public string[] Reduce(string[] plan)
		{
			var listOfDirections = plan.Reverse().ToList();

			for(int index = listOfDirections.Count() - 2; index > -1; index--)
			{
				var priorItem = listOfDirections[index + 1];
				var item = listOfDirections[index];
				if(item != priorItem)
				{
					if(IsInNorthSouth(priorItem, item) || IsInEastWest(priorItem, item))
					{
						listOfDirections.RemoveAt(index + 1);
						listOfDirections.RemoveAt(index);
						index = listOfDirections.Count() - 1;
					} 
				}
			}
			return listOfDirections.ToArray().Reverse().ToArray();
		}

		private bool IsInNorthSouth(string priorItem, string item)
		{
			return northSouth.Contains(item) && northSouth.Contains(priorItem);
		}

		private bool IsInEastWest(string priorItem, string item)
		{
			return eastWest.Contains(priorItem) && eastWest.Contains(item);
		}
	}

}

