namespace Year2022.Day4;

public static class Part2
{
    public static int Calculate(Tuple<IEnumerable<int>, IEnumerable<int>>[] input)
    {
        var score = 0;
        foreach (var pair in input)
        {
            if (pair.Item1
                    .Any(x => x == pair.Item2.First() || x == pair.Item2.Last())
                || pair.Item2
                    .Any(x => x == pair.Item1.First() || x == pair.Item1.Last()))
            {
                score++;
            }
        }

        return score;
    }
}
