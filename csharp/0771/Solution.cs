using System.Text.RegularExpressions;

namespace csharp._0771;

public class Solution 
{
    /// <summary>
    /// Beats with 2.25% of submissions with time complexity of O(n*m) and space complexity of O(n+m)
    /// </summary>
    public int NumJewelsInStones(string jewels, string stones) 
    {
        if (string.IsNullOrEmpty(jewels) || string.IsNullOrEmpty(stones))
            return 0;
        string pattern = $"[{Regex.Escape(jewels)}]";
        return Regex.Matches(stones, pattern).Count;
    }
}