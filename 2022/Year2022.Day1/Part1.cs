namespace Year2022.Day1;

public static class Part1
{
    public static int Calculate(string[] input)
    {
        var maxCalories = 0;
        var currentElfCalories = new List<int>();
        foreach (var calorie in input)
        {
            if (string.IsNullOrEmpty(calorie))
            {
                var currentElfCaloriesSum = currentElfCalories.Sum();
                if (currentElfCaloriesSum > maxCalories)
                {
                    maxCalories = currentElfCaloriesSum;
                }
                currentElfCalories.Clear();
                continue;
            }

            int.TryParse(calorie, out var value);
            currentElfCalories.Add(value);
        }

        return maxCalories;
    }
}