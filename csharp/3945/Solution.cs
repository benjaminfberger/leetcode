namespace csharp._3945;

public class Solution 
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(log10n) and space complexity of O(1)
    /// </summary>
    public int DigitFrequencyScore(int n) 
    {
        int score = 0;
        while (n > 0) 
        {
            score += n % 10;
            n /= 10;
        }
        return score;
    }
}