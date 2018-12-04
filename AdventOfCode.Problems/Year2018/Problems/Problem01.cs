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
	}
}