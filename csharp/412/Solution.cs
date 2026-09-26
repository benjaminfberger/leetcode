namespace csharp._412
{
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> ans = new();

            for (int i = 1; i <= n; i++)
            {
                int remainder = i % 15;
                switch (remainder)
                {
                    case 3:
                    case 6:
                    case 9:
                    case 12:
                        ans.Add("Fizz");
                        break;
                    case 5:
                    case 10:
                        ans.Add("Buzz");
                        break;
                    case 0:
                        ans.Add("FizzBuzz");
                        break;
                    default:
                        ans.Add(i.ToString());
                        break;
                }
            }
            return ans;
        }
    }
}
