namespace csharp._3190;

public class Solution
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public int MinimumOperations(int[] nums) 
    {
        int total = 0;
        foreach (int n in nums)
            switch (n % 3)
            {
                case 1:
                case 2:
                    total++;
                    break;
            }
        return total;
    }
}