#include <vector>

class Solution 
{
    /* 
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    int removeElement(std::vector<int>& nums, int val) 
    {
        int slow = 0;
        
        for (int fast = 0; fast < nums.size(); fast++)
            if (nums[fast] != val) 
            {
                nums[slow] = nums[fast];
                slow++;
            }
        return slow; 
    }
};