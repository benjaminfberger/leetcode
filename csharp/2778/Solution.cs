namespace csharp._2778;

public class Solution 
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public int SumOfSquares(int[] nums) 
    {
        int total = 0;
        for (int i = 1; i <= nums.Length; i++)
            switch (nums.Length % i)
            {
                case 0:
                    total += nums[i - 1] * nums[i - 1];
                    break;
            }

        return total;
    }
}