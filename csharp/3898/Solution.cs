namespace csharp._3898
{
    /// <summary>
    /// Beats 85.53% of submissions with time complexity of O(n^2) and space complexity of O(n)
    /// </summary>
    public class Solution
    {
        public int[] FindDegrees(int[][] matrix)
        {
            int n = matrix.Length;
            var ans = new int[n];

            for (int i = 0; i < n; i++)
            {
                int degree = 0;
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    degree += matrix[i][j];
                }
                ans[i] = degree;
            }

            return ans;
        }
    }
}
