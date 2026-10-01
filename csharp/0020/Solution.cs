namespace csharp._0020
{
    /// <summary>
    /// Beats 93.53% of submissions with time complexity of O(n) and space complexity of O(n)
    /// </summary>
    public class Solution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(c);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(') return false;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[') return false;
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{') return false;
                        break;
                }
            }
            return stack.Count == 0;
        }
    }
}
