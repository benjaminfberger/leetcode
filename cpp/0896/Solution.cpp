#include <vector>

class Solution 
{
    /*
     * Beats 37.2% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    bool isMonotonic(std::vector<int>& nums) 
    {
        bool increasing = true;
        bool decreasing = true;
        
        for (int i = 1; i < nums.size(); i++) 
        {
            if (nums[i] > nums[i - 1])
                decreasing = false;
            if (nums[i] < nums[i - 1])
                increasing = false;
            if (!increasing && !decreasing)
                return false;
        }
        return true;
    }
};
