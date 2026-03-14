public static class StatisticsHelper
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }

        int sum = 0;

        foreach (int value in values)
        {
            sum += value;
        }

        return (double)sum / values.Length;
    }
    public static int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }

        int max = values[0];

        foreach (int value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }

        return max;
    }
    public static int CalculateMin(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            return 0;
        }

        int min = values[0];

        foreach (int value in values)
        {
            if (value < min)
            {
                min = value;
            }
        }

        return min;
    }
}