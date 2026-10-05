namespace csharp._0856;

public class Solution
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public int ScoreOfParentheses(string s)
    {
        int score = 0;
        int depth = 0;
        for (int i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                    depth++;
                    break;
                default:
                    depth--;
                    if (s[i - 1] == '(')
                        score += 1 << depth;
                    break;
            }
        }
        return score;
    }
}