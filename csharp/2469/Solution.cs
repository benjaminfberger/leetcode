namespace csharp._2469;

public class Solution 
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(1) and space complexity of O(1)
    /// </summary>
    public double[] ConvertTemperature(double celsius) 
    {
        return new double[] { celsius + 273.15, celsius * 1.8 + 32f };
    }
}