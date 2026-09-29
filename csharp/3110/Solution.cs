namespace csharp._3110
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public class Solution
    {
        public int ScoreOfString(string s)
        {
            int score = 0;

            for (int i = 0; i < s.Length - 1; i++)
                score += Math.Abs(s[i] - s[i + 1]);

            return score;
        }
    }
}
