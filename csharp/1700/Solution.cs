namespace csharp._1700
{
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public class Solution
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            var counts = new int[2];
            foreach (int i in students)
                counts[i]++;

            foreach (int i in sandwiches)
                if (counts[i] == 0)
                    break;
                else counts[i]--;
            return counts[0] + counts[1];
        }
    }
}
