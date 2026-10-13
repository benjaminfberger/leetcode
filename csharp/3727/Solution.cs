namespace csharp._3727;

public class Solution 
{
    /// <summary>
    /// Beats 40% of submissions with time complexity of O(nlogn) and space complexity of O(n)
    /// </summary>
    public long MaxAlternatingSum(int[] nums) 
    {
        long score = 0;
        var squares = new long[nums.Length];
        
        for (int i = 0; i < nums.Length; i++)
            squares[i] = (long)nums[i] * nums[i]; 
            
        Array.Sort(squares);
        
        for (int i = 0; i < squares.Length; i++) 
            if (i < squares.Length / 2)
                score -= squares[i];
            else
                score += squares[i];
        
        return score;
    }
}
