using System;
using System.IO;
using AdventOfCode.Problems.Year2018;

namespace AdventOfCode.ConsoleApp
{
	class Program
	{
		#region [Fields]

		private static readonly string _inputFileDirectory = "AdventOfCode.Problems\\Year2018\\ProblemInput\\";

		#endregion

		#region [Methods]

		static void Main(string[] args)
		{
			// Problem01

			// get input from file
			string[] problem01Input = GetStringArrayFromInputFile("Problem01");

			int resultProblem1Part1 = Problem01.CalculateResultingFrequency(0, problem01Input);
			Console.WriteLine("Problem 01 Part 01 result is: {0}", resultProblem1Part1);

			int resultProblem1Part2 = Problem01.GetFirstRepeatingFrequency(0, problem01Input);
			Console.WriteLine("Problem 01 Part 02 result is: {0}", resultProblem1Part2);

			// Problem02

			// get input from file
			string[] problem02Input = GetStringArrayFromInputFile("Problem02");

			int resultProblem2Part1 = Problem02.ComputeChecksum(problem02Input);
			Console.WriteLine("Problem 02 Part 01 result is: {0}", resultProblem2Part1);

			string resultProblem2Part2 = Problem02.GetOffByOneStringPair(problem02Input, true);
			Console.WriteLine("Problem 02 Part 02 result is: {0}", resultProblem2Part2);

			// Problem05

			// get input from file
			string problem05Input = GetStringFromInputFile("Problem05");

			int resultProblem5Part1 = Problem05.RemoveAdjacentLetters(problem05Input);
			Console.WriteLine("Problem 05 Part 01 result is: {0}", resultProblem5Part1);

			int resultProblem5Part2 = Problem05.GetSmallestSubstringLength(problem05Input);
			Console.WriteLine("Problem 05 Part 02 result is: {0}", resultProblem5Part2);
		}

		#endregion

		#region [Private Methods]
		private static string[] GetStringArrayFromInputFile(string problemName)
		{
			var inputFile = Path.Combine(_inputFileDirectory, problemName, "input.txt");

			return File.ReadAllLines(inputFile);
		}

		private static string GetStringFromInputFile(string problemName)
		{
			var inputFile = Path.Combine(_inputFileDirectory, problemName, "input.txt");

			return File.ReadAllText(inputFile);
		}

		#endregion
	}
}
