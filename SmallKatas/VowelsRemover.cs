using System;
using System.Linq;

namespace SmallKatas
{
	public class VowelsRemover
	{
		public string Remove(string sentence)
		{
			var vowels = new char[]{ 'a', 'e', 'i', 'o', 'u' };

			var changedSentence = sentence.ToCharArray()
										  .Where(c => !vowels.Contains(char.ToLower(c)));

			return string.Join("", changedSentence);
		}
	}

}

