#include <string>
#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n*m) and space complexity of O(n*m)
     */
public:
    std::vector<std::string> createGrid(int m, int n) 
    {
        std::vector<std::string> grid(m, std::string(n, '#'));
        
        grid[0] = std::string(n, '.');
        
        for (int i = 0; i < m; i++)
            grid[i][n - 1] = '.';
        
        return grid;
    }
};
