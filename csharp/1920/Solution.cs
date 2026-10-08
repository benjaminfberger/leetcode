namespace csharp._1920;

public class Solution
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public int[] BuildArray(int[] nums)
    {
        var ans = new int[nums.Length];

        for (int i = 0; i < ans.Length; i++)
            ans[i] = nums[nums[i]];

        return ans;
    }
}