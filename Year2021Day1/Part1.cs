namespace Day1
{
    public static class Part1
    {
        public static int Calculate(int[] measurements)
        {
            var depthMeasurementIncrease = 0;
            for (var i = 0; i < measurements.Length - 1; i++)
                if (measurements[i] < measurements[i + 1])
                    depthMeasurementIncrease++;

            return depthMeasurementIncrease;
        }
    }
}