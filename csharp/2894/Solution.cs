namespace csharp._2894;

public class Solution 
{
    /// <summary>
    /// Beats 51.06% of solutions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public int DifferenceOfSums(int n, int m) 
    {
        int ans = 0;
        for (int i = 1; i <= n; i++)
            switch (i % m)
            {
                case 0:
                    ans -= i;
                    break;
                default:
                    ans += i;
                    break;
            }
        return ans;
    }
}