using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallKatas
{
	public class AcronymExpander
	{
		Dictionary<string, string> listOfPhrases = 
								new Dictionary<string, string>()
		{
			{ "lol", "laugh out loud" },
			{ "dw", "don't worry" },
			{ "hf", "have fun" },
			{ "gg", "good game" },
			{ "brb", "be right back" },
			{ "g2g", "got to go" },
			{ "wp", "well played" },
			{ "gl", "good luck" },
			{ "imo", "in my opinion" }
		};

		public string Expand(string acronym)
		{
			var listOfAcronyms = acronym.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
			var result = "";

			for(int index = 0; index < listOfAcronyms.Count(); index++)
			{
				var item = listOfAcronyms[index];
				result += listOfPhrases.ContainsKey(item) ? listOfPhrases[item] : item;

				if(index < listOfAcronyms.Count()-1)
				{
					result += " ";
				}
			}
			return result;
		}
	}
}

