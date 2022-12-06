namespace Year2022.Day4;

public static class Helper
{
    public static Tuple<IEnumerable<int>, IEnumerable<int>>[] File2EnumerableTuples(string input)
    {
        var file = File.ReadAllLines(input).Select(o =>
        {
            var first = o.Split(',').First();
            var second = o.Split(',').Last();
            int.TryParse(first.Split('-').First(), out int firstStart);
            int.TryParse(first.Split('-').Last(), out int firstEnd);
            int.TryParse(second.Split('-').First(), out int secondStart);
            int.TryParse(second.Split('-').Last(), out int secondEnd);
            return new Tuple<IEnumerable<int>, IEnumerable<int>>(
            Enumerable.Range(firstStart, firstEnd - firstStart + 1),
            Enumerable.Range(secondStart, secondEnd - secondStart + 1)
            );
        });
        return file.ToArray();
    }
}
