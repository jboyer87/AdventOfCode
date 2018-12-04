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
		}
	}
}