namespace csharp._3783
{
    /// <summary>
    /// Beats 100% of solutions with time complexity of O(logn) and space complexity of O(1)
    /// </summary>
    public class Solution
    {
        public int MirrorDistance(int n)
        {
            int original = n;
            int reverse = 0;
            while (n > 0)
            {
                int digit = n % 10;
                reverse = (reverse * 10) + digit;
                n /= 10;
            }
            return Math.Abs(original - reverse);
        }
    }
}
