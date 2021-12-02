using System;

namespace Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Day1
            var solutionDay1Part1 = Day1.Part1.Calculate(Day1.Helper.File2IntArray("Inputfiles/day1_1.txt"));
            Console.WriteLine($"Solution Day 1 Part 1: {solutionDay1Part1}");
            
            var solutionDay1Part2 = Day1.Part2.Calculate(Day1.Helper.File2IntArray("Inputfiles/day1_1.txt"));
            Console.WriteLine($"Solution Day 1 Part 2: {solutionDay1Part2}");
            #endregion

            #region Day2

            var solutionDay2Part1 = Day2.Part1.Calculate(Day2.Helper.File2CommandArray("Inputfiles/day2_1.txt"));
            Console.WriteLine($"Solution Day 2 Part 1: {solutionDay2Part1}");

            var solutionDay2Part2 = Day2.Part2.Calculate(Day2.Helper.File2CommandArray("Inputfiles/day2_1.txt"));
            Console.WriteLine($"Solution Day 2 Part 2: {solutionDay2Part2}");

            #endregion
        }
    }
}