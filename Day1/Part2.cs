using System.Data.SqlTypes;

namespace Day1
{
    public class Part2
    {
        public static int Calculate(int[] measurements)
        {
            var depthMeasurementIncrease = 0;
            for (var i = 0; i < measurements.Length - 3; i++)
            {
                var measurementSum = measurements[i] + measurements[i + 1] + measurements[i + 2];
                var nextMeasurementSum = measurements[i + 1] + measurements[i + 2] + measurements[i + 3];
                if (measurementSum < nextMeasurementSum)
                {
                    depthMeasurementIncrease++;
                }
            }

            return depthMeasurementIncrease;
        }
    }
}
