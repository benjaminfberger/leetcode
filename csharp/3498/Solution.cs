namespace csharp._3498
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public class Solution
    {
        public int ReverseDegree(string s)
        {
            int total = 0;
            for (int i = 1; i <= s.Length; i++)
                total += ('z' - s[i - 1] + 1) * i;
            return total;
        }
    }
}
