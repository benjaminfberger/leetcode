namespace csharp._3925
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public class Solution
    {
        public int[] ConcatWithReverse(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[n * 2];

            for (int i = 0; i < n; i++)
            {
                ans[i] = nums[i];
                ans[i + n] = nums[n - i - 1];
            }

            return ans;
        }
    }
}
