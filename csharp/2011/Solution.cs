namespace csharp._2011;

public class Solution {
    /// <summary>
    /// Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
    /// </summary>
    /// <param name="operations"></param>
    /// <returns></returns>
    public int FinalValueAfterOperations(string[] operations) 
    {
        int x = 0;
        foreach (string s in operations)
            switch (s)
            {
                case "X++":
                case "++X":
                    x++;
                    break;
                
                case "X--":
                case "--X":
                    x--;
                    break;
            }
        
        return x;
    }
}