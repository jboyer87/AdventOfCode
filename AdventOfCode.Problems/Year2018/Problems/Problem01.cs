using System.Collections.Generic;

namespace AdventOfCode.Problems.Year2018
{
	public class Problem01
	{
		// A value like +6 means the current frequency increases by 6; a value like -3 
		// means the current frequency decreases by 3. For example, if the device displays
		// frequency changes of +1, -2, +3, +1, the resulting frequency would be 3.
		public static int CalculateResultingFrequency(int startingFrequency, string[] frequencyChanges)
		{
			if (frequencyChanges.Length == 0)
				return startingFrequency;

			foreach (var frequency in frequencyChanges)
			{
				int current = int.Parse(frequency);

				startingFrequency += current;
			}

			return startingFrequency;
		}

		public static int GetFirstRepeatingFrequency(int startingFrequency, string[] frequencyChanges)
		{
			HashSet<int> seen = new HashSet<int>();

			int runningTotal = startingFrequency;

			foreach (var frequency in frequencyChanges)
			{
				int current = int.Parse(frequency);

				runningTotal += current;

				int previousSize = seen.Count;

				seen.Add(runningTotal);

				// If the size of the hashset has not increased, it was a dupe
				if (previousSize == seen.Count)
				{
					return runningTotal;
				}
			}

			// return 0 if nothing repeated
			return 0;
		}
	}
}