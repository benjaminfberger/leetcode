#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    int diagonalSum(std::vector<std::vector<int>>& mat) 
    {
        int total = 0;
        int n = mat.size();
    
        for (size_t i = 0; i < n; ++i) 
        {
            total += mat[i][i];
            total += mat[i][n - 1 - i];
        }
        if (n % 2 != 0)
            total -= mat[n / 2][n / 2];
    
        return total;
    }
};
