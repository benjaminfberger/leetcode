namespace csharp._0387;

public class Solution
{
    /// <summary>
    /// Beats 47.86% of submissions with time complexity of O(n) and space complexity of O(n)
    /// </summary>
    public int FirstUniqChar(string s)
    {
        var dict = new Dictionary<char, int>();
        
        foreach (char c in s)
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;

        for (int i = 0; i < s.Length; i++)
            if (dict[s[i]] == 1)
                return i;
        
        return -1;
    }
}
