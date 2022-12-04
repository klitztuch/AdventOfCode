namespace Year2022.Day1;

public static class Part2
{
    public static int Calculate(string[] input)
    {
        var currentElfCalories = new List<int>();
        var caloriesProElf = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            var calorie = input[i];
            if (string.IsNullOrEmpty(calorie) || i == input.Length)
            {
                var currentElfCaloriesSum = currentElfCalories.Sum();
                caloriesProElf.Add(currentElfCaloriesSum);
                currentElfCalories.Clear();
            }
            int.TryParse(calorie, out var value);
            currentElfCalories.Add(value);
        }

        return caloriesProElf.OrderByDescending(o => o).Take(3).Sum();
    }
}
