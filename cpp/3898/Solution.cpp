#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n^2) and space complexity of O(n^2)
     */
public:
    std::vector<int> findDegrees(std::vector<std::vector<int>>& matrix) 
    {
        std::vector<int> degree;
        for (int i = 0; i < std::size(matrix); i++) 
        {
            int total = 0;
            for (int j = 0; j < std::size(matrix[i]); j++)
                if (matrix[i][j] == 1)
                    total++;
            degree.push_back(total);
        }
        return degree;
    }
};
