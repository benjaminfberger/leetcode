namespace csharp._3668;

public class Solution 
{
    /// <summary>
    /// Beats 73.68% of submissions with time complexity of O(n) and space complexity of O(n)
    /// </summary>
    public int[] RecoverOrder(int[] order, int[] friends) 
    {
        var friendSet = new HashSet<int>(friends);
        var ans = new int[friends.Length]; 
        int index = 0;

        for (int i = 0; i < order.Length; i++)
            if (friendSet.Contains(order[i]))
                ans[index++] = order[i]; 
        
        return ans;
    }
}