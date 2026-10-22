#include <vector>

class Solution
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    bool checkStraightLine(std::vector<std::vector<int>>& coordinates) 
    {
        int deltaY = coordinates[1][1] - coordinates[0][1];
        int deltaX = coordinates[1][0] - coordinates[0][0];

        if (deltaX == 0) 
        {
            for (int i = 2; i < coordinates.size(); i++)
                if (coordinates[i][0] != coordinates[0][0]) 
                    return false;
            return true;
        }
        float m = (float)deltaY / deltaX;
        float c = coordinates[0][1] - m * coordinates[0][0];

        for (int i = 2; i < coordinates.size(); i++)
            if (abs(coordinates[i][1] - (m * coordinates[i][0] + c)) > 1e-5)
                return false;
        return true;
    }
};
