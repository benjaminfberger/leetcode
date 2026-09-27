namespace csharp._1190
{
    /// <summary>
    /// Beats 50% of submissions with time complexity of O(n^2) and space complexity of O(n)
    /// </summary>
    public class Solution
    {
        public string ReverseParentheses(string s)
        {
            Stack<char> stack = new();

            foreach (char c in s)
                switch (c)
                {
                    case ')':
                        Queue<char> q = new Queue<char>();

                        while (stack.Count > 0 && stack.Peek() != '(')
                            q.Enqueue(stack.Pop());

                        if (stack.Count > 0)
                            stack.Pop();

                        while (q.Count > 0)
                            stack.Push(q.Dequeue());

                        break;

                    default:
                        stack.Push(c);
                        break;
                }

            char[] ans = stack.ToArray();
            Array.Reverse(ans);

            return new string(ans);
        }
    }
}
