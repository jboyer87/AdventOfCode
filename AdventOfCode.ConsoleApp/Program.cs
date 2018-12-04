using System;
using System.IO;
using AdventOfCode.Problems.Year2018;

namespace AdventOfCode.ConsoleApp
{
	class Program
	{
		#region [ Fields ]

		private static readonly string _inputFileDirectory = "AdventOfCode.Problems\\Year2018\\ProblemInput\\";

		#endregion
		static void Main(string[] args)
		{
			// Problem01

			string[] problem01Input;

			var inputFile = Path.Combine(_inputFileDirectory, "Problem01", "input.txt");

			problem01Input = File.ReadAllLines(inputFile);

			int resultPartOne = Problem01.CalculateResultingFrequency(0, problem01Input);

			Console.WriteLine("Problem 01 Part 01 result is: {0}", resultPartOne);

			int resultPartTwo = Problem01.GetFirstRepeatingFrequency(0, problem01Input);

			Console.WriteLine("Problem 01 Part 02 result is: {0}", resultPartTwo);
		
		}
	}
}
