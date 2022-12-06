namespace Year2022.Day4;

public static class Part1
{
    public static int Calculate(Tuple<IEnumerable<int>, IEnumerable<int>>[] input)
    {
        var score = 0;
        foreach (var pair in input)
        {

            if ((pair.Item1.First() <= pair.Item2.First() && pair.Item1.Last() >= pair.Item2.Last())
            || (pair.Item2.First() <= pair.Item1.First() && pair.Item2.Last() >= pair.Item1.Last()))
            {
                score++;
            }

        }

        return score;

    }
}
