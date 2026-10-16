#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    int arraySign(std::vector<int>& nums) 
    {
        int sign = 1;
        for (int n : nums)
            if (n == 0)
                return 0;
            else if (n < 0)
                sign = -sign;
                
        return sign;
    }
};
