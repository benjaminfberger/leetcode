#include <vector>

class Solution
{
    /*
     * Beats 67.16% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    long long countSubarrays(std::vector<int>& nums, int minK, int maxK) 
    {
        long long ans = 0;
        int subarrayStart = 0;
        for (int i = 0; i < size(nums); i++)
            if (nums[i] >= minK && nums[i] <= maxK) 
            {
                ans++;
                ans += abs(subarrayStart - i);
            }
            else
                subarrayStart = i + 1;
        return ans;
    }
};
