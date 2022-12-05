using System.Text;

namespace Year2022.Day3;

public static class Part1
{
    public static int Calculate(string[] rucksacks)
    {
        var points = 0;
        var duplicates = new List<string>();
        foreach (var rucksack in rucksacks)
        {
            var firstCompartment = rucksack.Substring(0, rucksack.Length / 2);
            var secondCompartment = rucksack.Substring(rucksack.Length / 2, rucksack.Length / 2);

            var firstBytes = Encoding.ASCII.GetBytes(firstCompartment);
            var secondBytes = Encoding.ASCII.GetBytes(secondCompartment);

            duplicates.Add(Encoding.ASCII.GetString(firstBytes.Intersect(secondBytes).ToArray()));
        }

        points = duplicates.Select(Helper.Item2Points)
                    .Sum();
        return points;
    }


}
