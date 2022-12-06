using System;

namespace Runner;
public class Program
{
    public static void Main(string[] args)
    {
        switch (args.FirstOrDefault())
        {
            case "2020":
                break;
            case "2021":
                RunYear2021();
                break;
            case "2022":
                RunYear2022();
                break;
        }
    }

    private static void RunYear2021()
    {
        // #region Year2021Day1
        //
        // var solutionDay1Part1 = Part1.Calculate(Helper.File2IntArray("Inputfiles/day1_1.txt"));
        // Console.WriteLine($"Solution Day 1 Part 1: {solutionDay1Part1}");
        //
        // var solutionDay1Part2 = Part2.Calculate(Helper.File2IntArray("Inputfiles/day1_1.txt"));
        // Console.WriteLine($"Solution Day 1 Part 2: {solutionDay1Part2}");
        //
        // #endregion
        //
        // #region Year2021Day2
        //
        // var solutionDay2Part1 = Day2.Part1.Calculate(Day2.Helper.File2CommandArray("Inputfiles/day2_1.txt"));
        // Console.WriteLine($"Solution Day 2 Part 1: {solutionDay2Part1}");
        //
        // var solutionDay2Part2 = Day2.Part2.Calculate(Day2.Helper.File2CommandArray("Inputfiles/day2_1.txt"));
        // Console.WriteLine($"Solution Day 2 Part 2: {solutionDay2Part2}");
        //
        // #endregion
        //
        // #region Year2021Day3
        //
        // var solutionDay3Part1 = Day3.Part1.Calculate(Day3.Helper.File2BitArrays("Inputfiles/day3_1.txt"));
        // Console.WriteLine($"Solution Day 3 Part 1: {solutionDay3Part1}");
        //
        // #endregion
    }

    #region Year2022

    private static void RunYear2022()
    {
        Console.WriteLine("Year 2022");
        #region Day1

        Console.WriteLine("Day 1");

        #region Part1

        System.Console.WriteLine("Part 1");
        // var inputfile = GetInputFilename(typeof(Year2022.Day1.Part1));
        string inputfile = "Inputfiles/2022/year2022_day1.txt";
        var input = Year2022.Day1.Helper.File2StringArray(inputfile);
        var result = Year2022.Day1.Part1.Calculate(input);
        System.Console.WriteLine(result);

        #endregion

        #region Part2

        System.Console.WriteLine("Part 2");

        result = Year2022.Day1.Part2.Calculate(input);
        System.Console.WriteLine(result);

        #endregion

        #endregion
        #region Day2
        System.Console.WriteLine("Day 2");
        #region Part1
        System.Console.WriteLine("Part 1");
        inputfile = "Inputfiles/2022/year2022_day2.txt";
        var moves = Year2022.Day2.Helper.File2Moves(inputfile);
        result = Year2022.Day2.Part1.Calculate(moves);
        System.Console.WriteLine(result);
        #endregion
        #region Part2
        System.Console.WriteLine("Part 2");
        result = Year2022.Day2.Part2.Calculate(moves);
        System.Console.WriteLine(result);
        #endregion
        #endregion

        #region Day3
        System.Console.WriteLine("Day 3");
        #region Part1
        System.Console.WriteLine("Part 1");
        inputfile = "Inputfiles/2022/year2022_day3.txt";
        input = Year2022.Day3.Helper.File2StringArray(inputfile);
        result = Year2022.Day3.Part1.Calculate(input);
        System.Console.WriteLine(result);
        #endregion
        #region Part2
        System.Console.WriteLine("Part 2");
        result = Year2022.Day3.Part2.Calculate(input);
        System.Console.WriteLine(result);
        #endregion
        #endregion

        #region Day4
        System.Console.WriteLine("Day 4");
        #region Part1
        System.Console.WriteLine("Part 1");
        inputfile = "Inputfiles/2022/year2022_day4.txt";
        var day4Input = Year2022.Day4.Helper.File2EnumerableTuples(inputfile);
        result = Year2022.Day4.Part1.Calculate(day4Input);
        System.Console.WriteLine(result);
        #endregion
        #region Part2
        System.Console.WriteLine("Part 2");
        result = Year2022.Day4.Part2.Calculate(day4Input);
        System.Console.WriteLine(result);
        #endregion
        #endregion
    }

    private static string GetInputFilename(Type type)
    {
        return "";
    }


    #endregion
}