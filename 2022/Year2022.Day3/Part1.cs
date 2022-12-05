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

        points = duplicates.Select(Item2Points)
                    .Sum();
        return points;
    }

    private static int Item2Points(string item)
    {
        // Set start value for ascii conversion
        var value = -96;
        var letter = char.Parse(item);
        if (Char.IsUpper(letter))
        {
            value += 26;
        }
        value += char.ToLower(letter);
        return value;
    }
}
