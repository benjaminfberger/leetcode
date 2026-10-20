#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    void moveZeroes(std::vector<int>& nums) 
    {
        int lP = 0;
        for (int rP = 0; rP < size(nums); rP++)
            if (nums[rP] != 0) {
                int temp = nums[lP];
                nums[lP] = nums[rP];
                nums[rP] = temp;
                lP++;
            }
    }
};
