namespace csharp._1614
{
    /// <summary>
    /// Beats 100% of solutions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public class Solution
    {
        public int MaxDepth(string s)
        {
            int maxDepth = 0;
            int currentDepth = 0;
            foreach (char c in s)
                switch (c)
                {
                    case '(':
                        currentDepth++;
                        if (currentDepth > maxDepth)
                            maxDepth = currentDepth;
                        break;
                    case ')':
                        currentDepth--;
                        break;
                }
            return maxDepth;
        }
    }
}
