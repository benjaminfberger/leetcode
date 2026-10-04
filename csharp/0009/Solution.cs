namespace csharp._9
{
    /// <summary>
    /// Beats 32.09% of submissions with time complexity of O(logn) and space complexty of O(1)
    /// </summary>
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            int original = x;
            int ans = 0;
            while (x > 0)
            {
                int digit = x % 10;
                ans = (ans * 10) + digit;
                x /= 10;
            }
            return original == ans;
        }
    }
}
