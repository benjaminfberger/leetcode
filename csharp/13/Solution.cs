namespace csharp._13
{
    /// <summary>
    /// Beats 67.25% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    public class Solution
    {
        private Dictionary<char, int> mappings = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
        public int RomanToInt(string s)
        {
            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int current = mappings[s[i]];
                if (i + 1 < s.Length)
                {
                    int nextVal = mappings[s[i + 1]];

                    if (current < nextVal)
                    {
                        ans -= current;
                        continue;
                    }
                }
                ans += current;

            }
            return ans;
        }
    }
}
