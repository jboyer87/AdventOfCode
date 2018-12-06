using System;
using AdventOfCode.Problems.Year2018;
using Xunit;

namespace AdventOfCode.UnitTests
{
	public class Year2018Tests
	{
		[Fact]
		public void Problem01Should()
		{
			int startingFrequency = 0;

			string[] frequencyChanges = new string[] { "0", "+1", "-2", "+3", "+1" };

			int part3ShouldBe = 3;

			int part1Result = Problem01.CalculateResultingFrequency(startingFrequency, frequencyChanges);

			Assert.Equal(part3ShouldBe, part1Result);

			string[] frequencyChanges2 = new string[] { "+3", "+3", "+4", "-2", "-4" };

			int part2ShouldBe = 10;

			int part2Result = Problem01.GetFirstRepeatingFrequency(startingFrequency, frequencyChanges2);

			Assert.Equal(part2ShouldBe, part2Result);
		}

		[Fact]
		public void Problem02Should()
		{
			string[] boxIds = new string[] {
				"abcdef",
				"bababc",
				"abbcde",
				"abcccd",
				"aabcdd",
				"abcdee",
				"ababab"
			};

			int part1ShouldBe = 12;

			int part1Result = Problem02.ComputeChecksum(boxIds);

			Assert.Equal(part1ShouldBe, part1Result);

			string[] boxIds2 = new string[] {
				"abcde",
				"fghij",
				"klmno",
				"pqrst",
				"fguij",
				"axcye",
				"wvxyz"
			};

			string part2ShouldBe = "fgij";

			string part2Result = Problem02.GetOffByOneStringPair(boxIds2, true);

			Assert.Equal(part2ShouldBe, part2Result);
		}

		[Fact]
		public void Problem05Should()
		{
			string polymer = "dabAcCaCBAcCcaDA";

			int part1ShouldBe = 10;

			int part1Result = Problem05.RemoveAdjacentLetters(polymer);

			Assert.Equal(part1ShouldBe, part1Result);

			int part2ShouldBe = 4;

			int part2Result = Problem05.GetSmallestSubstringLength(polymer);

			Assert.Equal(part2ShouldBe, part2Result);
		}
	}
}