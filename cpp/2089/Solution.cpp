#include <vector>
#include <algorithm>
class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(nlogn) and space complexity of O(n)
     */
public:
    std::vector<int> targetIndices(std::vector<int>& nums, int target) 
    {
        std::sort(nums.begin(), nums.end());
        std::vector<int> res;
        for (int i = 0; i < size(nums); i++)
            if (nums[i] == target)
                res.push_back(i);
        
        return res;
    }
};
