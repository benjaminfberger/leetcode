namespace csharp._0389;

public class Solution 
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public char FindTheDifference(string s, string t) 
    {
        char result = (char)0;

        foreach (char c in s)
            result ^= c;
        foreach (char c in t) 
            result ^= c;

        return result;
    }
}