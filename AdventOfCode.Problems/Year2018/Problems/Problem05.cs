using System.Text;

namespace AdventOfCode.Problems.Year2018
{
	public class Problem05
	{
		// Part 1 asks us to repeatedly remove all adjacent characters in a string and 
		// then return the size of the string after all adjacent characters that match in 
		// letter but not case have been removed (they cancel each other out, so both are
		// removed)
		public static int RemoveAdjacentLetters(string input)
		{
			if (input.Length == 0)
				return 0;

			StringBuilder result = new StringBuilder(input);

			// end the loop at Length -1, we lookahead in the loop
			for (int i = 0; i < result.Length - 1; i++)
			{
				var first = (int)result[i];
				var second = (int)result[i + 1];

				// Compare to see if the first is the second, but in opposite case using
				// ascii character values. Assumes the input is ascii
				if (first == second + 32 || first == second - 32)
				{
					result.Remove(i, 2);

					// Jump back 2 spaces to compare in case of a new adjacent pair
					i = i - 2;

					// Don't allow i to go negative. Loop advance will go from -1 --> 0
					if (i < 0)
						i = -1;
				}
			}

			return result.Length;
		}


		// Part 2 asks us to see what removing all instances of a letter (both upper and 
		// lower) does. If we remove all a, A, does the resulting string length shrink? Do
		// this for each letter in the alphabet, and return the length of the smallest 
		// resulting string.
		public static int GetSmallestSubstringLength(string input)
		{
			if (input.Length == 0)
				return 0;

			// point where "a" appears in ascii character set
			int asciiOffset = 97;
			int maxAsciiCharacter = 122;

			int smallestResult = input.Length;

			// Try with each character set, store the result in an array
			for (int i = asciiOffset; i <= maxAsciiCharacter; i++)
			{
				char lowercaseCurrent = (char)i;
				char uppercaseCurrent = (char)(lowercaseCurrent - 32);

				StringBuilder result = new StringBuilder(input);

				for (int j = 0; j < result.Length; j++)
				{
					if (result[j] == lowercaseCurrent || result[j] == uppercaseCurrent)
					{
						result.Remove(j, 1);
						// Go back one and check, just in case there are adjacent removals
						j--;
					}
				}

				int newLength = RemoveAdjacentLetters(result.ToString());

				smallestResult = newLength < smallestResult
					? newLength
					: smallestResult;
			}

			return smallestResult;
		}
	}
}