#include <algorithm>
#include<vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    bool canMakeArithmeticProgression(std::vector<int>& arr) 
    {
        std::sort(arr.begin(), arr.end());
        int diff = arr[1] - arr[0];
        
        for (int i = 1; i < size(arr) - 1; i++) 
            if (arr[i + 1] - arr[i] != diff) 
                return false;

        return true;
    }
};
