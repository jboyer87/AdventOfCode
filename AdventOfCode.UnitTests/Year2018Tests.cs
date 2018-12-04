using System;
using AdventOfCode.Problems.Year2018;
using Xunit;

namespace AdventOfCode.UnitTests
{
	public class Year2018Tests
	{
		[Fact]
		public void Problem01Test()
		{
			int startingFrequency = 0;

			string[] frequencyChanges = new string[] { "0", "+1", "-2", "+3", "+1" };

			int shouldBe = 3;

			int result = Problem01.CalculateResultingFrequency(startingFrequency, frequencyChanges);

			Assert.Equal(shouldBe, result);

			string[] frequencyChanges2 = new string[] { "+3", "+3", "+4", "-2", "-4" };

			int shouldBe2 = 10;

			int result2 = Problem01.GetFirstRepeatingFrequency(startingFrequency, frequencyChanges2);

			Assert.Equal(shouldBe2, result2);
		}
	}
}