namespace csharp._3760;

public class Solution 
{
    /// <summary>
    /// Beats 98.36% of sumbissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public int MaxDistinct(string s) 
    {
        int total = 0;
        int mask = 0;
        foreach (char c in s)
        {
            int bit = c - 'a';
            if ((mask & (1 << bit)) == 0)
            {
                mask |= (1 << bit);
                total++;
            }

        }

        return total;
    }
}