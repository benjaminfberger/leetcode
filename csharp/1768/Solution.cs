namespace csharp._1768;

public class Solution 
{
    /// <summary>
    /// Beats 78.80% of submissions with time complexity of O(n) and space complexity of O(n)
    /// </summary>
    public string MergeAlternately(string word1, string word2) 
    {
        string result = string.Empty;
        int i = 0;
        while ( i < word1.Length || i < word2.Length)
        {
            if (i < word1.Length)
                result += word1[i];
            if (i < word2.Length)
                result += word2[i];
            i++;
        }
        return result;
    }
}