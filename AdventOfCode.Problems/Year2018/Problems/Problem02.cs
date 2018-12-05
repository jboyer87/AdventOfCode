using System;
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

		// Part two asks us to compare two strings and find the set of strings that have 
		// at most one character that differs. We are then asked to return the characters
		// that the two strings have in common. We can implement a hamming distance 
		// algorithm to find the strings that are only off by one character, and then
		// return the string minus that character.
		public static string GetOffByOneStringPair(string[] stringPairs, bool orderMatters)
		{
			foreach (var word in stringPairs)
			{
				for (int i = 0; i < stringPairs.Length; i++)
				{
					if (word == stringPairs[i])
						continue;

					if (GetHammingDistance(word, stringPairs[i], orderMatters) == 1)
					{
						return GetMatchingCharacters(word, stringPairs[i]);
					}
				}
			}

			throw new Exception("None of the pairs match");
		}


		// Gets the hamming distance for two strings
		private static int GetHammingDistance(string first, string second, bool orderMatters)
		{
			if (first.Length != second.Length)
				throw new ArgumentException("Input strings must have identical lengths");

			if (first == second)
				return 0;

			int distance = 0;

			if (!orderMatters)
			{
				var firstAsCharArray = first.ToCharArray();
				Array.Sort(firstAsCharArray);

				var secondAsCharArray = first.ToCharArray();
				Array.Sort(secondAsCharArray);

				first = firstAsCharArray.ToString();
				second = secondAsCharArray.ToString();
			}

			for (int i = 0; i < first.Length; i++)
			{
				if (first[i] != second[i])
					distance++;
			}

			return distance;
		}

		// Returns the characters that two strings have in common
		private static string GetMatchingCharacters(string first, string second)
		{
			if (first.Length == 0 || second.Length == 0)
				throw new ArgumentException("Strings cannot be null or empty");

			if (first.Length != second.Length)
				throw new ArgumentException("Strings must have identical lengths");

			string matchingCharacters = "";

			for (int i = 0; i < first.Length; i++)
			{
				if (first[i] == second[i])
					matchingCharacters += first[i];
			}

			return matchingCharacters;
		}


	}
}