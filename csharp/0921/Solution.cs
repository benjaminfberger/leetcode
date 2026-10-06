namespace csharp._0921;

public class Solution
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public int MinAddToMakeValid(string s)
    {
        int leftParentheses = 0;
        int score = 0;

        foreach (char c in s)
        {
            switch (c)
            {
                case '(':
                    score++;
                    break;
                case ')':
                    if (score > 0)
                        score--;
                    else
                        leftParentheses++;
                    break;
            }
        }
        return leftParentheses + score;
    }
}
