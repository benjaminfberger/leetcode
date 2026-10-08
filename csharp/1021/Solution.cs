using System.Text;

namespace csharp._1021;

public class Solution 
{
    /// <summary>
    /// Beats 99.25% of solutions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public string RemoveOuterParentheses(string s) 
    {
        var sb = new StringBuilder();
        int depth = 0;
        
        foreach (char c in s)
            switch (c)
            {
                case '(':
                    if (depth > 0)
                        sb.Append(c);
                    depth++;
                    break;
                default:
                    depth--;
                    if (depth > 0)
                        sb.Append(c);
                    break;
            }
        return sb.ToString();
    }
}