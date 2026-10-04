namespace csharp._0678
{
    public class Solution
    {
        /// <summary>
        /// Beats 100% of solutions with time complexity of O(n) and space complexity of O(1)
        /// </summary>
        public bool CheckValidString(string s)
        {
            int min = 0;
            int max = 0;

            foreach (char c in s)
            {
                switch (c)
                {
                    case '(':
                        min++;
                        max++;
                        break;
                    case ')':
                        min--;
                        max--;
                        break;
                    default:
                        min--;
                        max++;
                        break;
                }
                if (max < 0)
                    return false;
                if (min < 0)
                    min = 0;
            }
            return min == 0;
        }
    }
}
