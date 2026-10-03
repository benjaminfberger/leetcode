namespace csharp._3512
{
    /// <summary>
    /// Beats 83.82% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public class Solution
    {
        public int MinOperations(int[] nums, int k)
        {
            var sum = 0;
            foreach (var n in nums)
                sum += n;
            return sum % k;
        }
    }
}
