using System.Collections.Generic;

namespace AdventOfCode.Problems.Year2018
{
	public class Problem02
	{
		// For part one, the object is to write a function that takes an array of strings 
		// and checks each string for repeating characters. If a character repeats twice,
		// add it to the total for twice repeating characters. If a character repeats
		// three times, add it to a total for thrice repeated characters. Multiply the two
		// totals together to arrive at a checksum.
		public static int ComputeChecksum(string[] boxIds)
		{
			if (boxIds.Length == 0)
				return 0;

			int twiceRepeating = 0;
			int thriceRepeating = 0;

			foreach (var word in boxIds)
			{
				var characterCounts = new Dictionary<char, int>();

				foreach (var letter in word)
				{
					if (characterCounts.ContainsKey(letter))
					{
						characterCounts[letter]++;
					}
					else
					{
						characterCounts.Add(letter, 1);
					}
				}

				bool foundTwice = false;
				bool foundThrice = false;

				foreach (var character in characterCounts)
				{
					if (!foundTwice && character.Value == 2)
					{
						twiceRepeating++;
						foundTwice = true;
					}

					if (!foundThrice && character.Value == 3)
					{
						thriceRepeating++;
						foundThrice = true;
					}

					if (foundTwice && foundThrice)
						break;
				}
			}

			return twiceRepeating * thriceRepeating;
		}
	}
}