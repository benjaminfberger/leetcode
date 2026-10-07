namespace csharp._1689;

public class Solution 
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public int MinPartitions(string n) 
    {
        int max = 0;
        foreach (char c in n)
        {
            int val = c - '0';
            if (val > max)
                max = val;
        }
        return max;
    }
}