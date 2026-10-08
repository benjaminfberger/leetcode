namespace csharp._2161;

public class Solution 
{
    /// <summary>
    /// Beats 25.32% of solutions with time complexity of O(n) and space complexity of O(n)
    /// </summary>
    public int[] PivotArray(int[] nums, int pivot) 
    {
        var less = new List<int>();
        var greater = new List<int>();
        int equal = 0;
        
        foreach (int n in nums) 
            if (n > pivot)
                greater.Add(n);
            else if (n < pivot)
                less.Add(n);
            else
                equal++;

        return [..less, ..Enumerable.Repeat(pivot, equal), ..greater];
    }
}
