namespace chsharp._3350
{
    public class Solution
    {
        public int SmallestIndex(int[] nums)
        {
            HashSet<int> vals = new();
            for (int i = 0; i < nums.Length; i++)
            {
                string s = nums[i].ToString();
                int total = 0;
                foreach (char c in s)
                    total += int.Parse(c.ToString());
                if (total == i) vals.Add(i);
            }
            if (vals.Count <= 0) return -1;
            return vals.OrderBy(x => x).ToArray()[0];
        }
    }
}
