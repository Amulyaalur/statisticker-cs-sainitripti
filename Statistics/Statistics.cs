using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
            //Implement statistics here
            Stats stats = new Stats();
            stats.average = CalculateAverage(numbers);
            stats.max = FindMaxElement(numbers);
            stats.min = FindMinElement(numbers);
            return stats;
        }
        public double CalculateAverage(List<double> numbers)
        {
            if(numbers.Count == 0)
            {
                return Double.NaN;
            }

            double sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            double average = sum / numbers.Count;
            
            return average;
        }

        public double FindMaxElement(List<double> numbers)
        {
            if (numbers.Count == 0)
            {
                return Double.NaN;
            }

            double max = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                max = Math.Max(max, numbers[i]);
            }

            return max;
        }
        public double FindMinElement(List<double> numbers)
        {
            if (numbers.Count == 0)
            {
                return Double.NaN;
            }

            double min = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                min = Math.Min(min, numbers[i]);
            }

            return min;
        }
    }

    public struct Stats
    {
        public double average;
        public double max;
        public double min;
    }
}
