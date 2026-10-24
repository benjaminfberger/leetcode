#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    int peakValleyDifference(std::vector<int>& nums) 
    {
        int vS = 0;
        int pS = 0;
        for (int i = 1; i < size(nums) - 1; i++)
            if (nums[i] < nums[i - 1] && nums[i] < nums[i + 1])
                vS += nums[i];
            else if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                pS += nums[i];
        return pS - vS;
    }
};
