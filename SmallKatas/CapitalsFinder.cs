using System;
using System.Linq;

namespace SmallKatas
{
	public class CapitalsFinder
	{
		public int[] FindIndexes(string sentence)
		{
			var indexesFound = sentence.ToCharArray().Select((v, i) => new {Index = i, Value = v})
				.Where(c => char.IsUpper(c.Value))
				.Select(c => c.Index);

			return indexesFound.ToArray();
		}
	}

}

