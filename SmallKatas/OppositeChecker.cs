using System;

namespace SmallKatas
{
	public class OppositeChecker
	{
		public bool checkForOddAndEvenNumbers(int firstNumber, int secondNumber)
		{
			if(IsOddNumber(firstNumber) && IsEvenNumber(secondNumber))
			{
				return true;
			}

			if(IsEvenNumber(firstNumber) && IsOddNumber(secondNumber))
			{
				return true;
			}

			return false;
		}

		private bool IsOddNumber(int number)
		{
			return number % 2 == 0;
		}

		private bool IsEvenNumber(int number)
		{
			return !IsOddNumber(number);
		}
	}
}

