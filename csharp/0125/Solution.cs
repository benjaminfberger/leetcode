namespace csharp._0125
{
    /// <summary>
    /// Beats 21.73% of submissions with time complexity of O(n) and space complexity of O(n)
    /// </summary>
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            return s == new string(s.Reverse().ToArray());
        }
    }
}
