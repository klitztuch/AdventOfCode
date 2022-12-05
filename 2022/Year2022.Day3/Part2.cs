using System.Text;

namespace Year2022.Day3;

public static class Part2
{
    public static int Calculate(string[] rucksacks)
    {
        var index = 0;
        var groups = rucksacks.GroupBy(o => index++ / 3);
        var points = 0;
        var duplicates = new List<string>();
        foreach (var group in groups)
        {
            var firstBytes = Encoding.ASCII.GetBytes(group.FirstOrDefault());
            var secondBytes = Encoding.ASCII.GetBytes(group.Skip(1).FirstOrDefault());
            var thirdBytes = Encoding.ASCII.GetBytes(group.Skip(2).FirstOrDefault());

            duplicates.Add(Encoding.ASCII.GetString(firstBytes.Intersect(secondBytes).Intersect(thirdBytes).ToArray()));
        }
        points = duplicates.Select(Helper.Item2Points)
                    .Sum();
        return points;
    }
}
