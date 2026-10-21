#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n*m) and space complexity of O(1)
     */
public:
    int maximumWealth(std::vector<std::vector<int>>& accounts) 
    {
        int max = 0;
        for (int i = 0; i < size(accounts); i++) 
        {
            int current = 0;
            for (int j = 0; j < size(accounts[0]); j++)
                current += accounts[i][j];
            if (current > max)
                max = current;
        }
        return max;
    }
};
