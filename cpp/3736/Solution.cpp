#include <vector>
#include <algorithm>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(nlogn) and space complexity of O(1)
     */
public:
    int minMoves(std::vector<int>& nums) 
    {
        std::sort(nums.begin(), nums.end(), std::greater<>());
        int moves = 0;
        int biggest = nums[0];
        for (int i = 1; i < size(nums); i++)
            moves += biggest - nums[i];
        return moves;
    }
};
