#include <iterator>
#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    int alternatingSum(std::vector<int>& nums) 
    {
        int total = 0;
        for (int i = 0; i < std::size(nums); i++)
            if (i % 2 == 0)
                total += nums[i];
            else
                total -= nums[i];
        return total;
    }
};
