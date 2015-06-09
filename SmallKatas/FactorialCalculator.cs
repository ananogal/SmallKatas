using System;

namespace SmallKatas
{
	public class FactorialCalculator
	{
		public int Calculate(int number)
		{
			if(number < 0 || number > 12)
			{
				throw new ArgumentOutOfRangeException();
			}
			if(number == 0)
			{
				return 1;
			}

			var result = 1;
			for(int start = 1; start < number + 1; start++)
			{
				result *= start;
			}
			return result;
		}
	}

}

