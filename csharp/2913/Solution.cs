namespace csharp._2913;

public class Solution 
{
    /// <summary>
    /// Beats 76.92% of submissions with time complexity of O(n^2) and space complexity of O(n)
    /// </summary>
    public int SumCounts(IList<int> nums) 
    {
        int total = 0;
        for (int i = 0; i < nums.Count(); i++) 
        {
            var hash = new HashSet<int>();
            for (int j = i; j < nums.Count(); j++) 
            {
                hash.Add(nums[j]);
                total += hash.Count() * hash.Count();
            }
        }
        return total;
    }
}