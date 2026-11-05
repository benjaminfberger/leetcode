#include <algorithm>
#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(nlogn + mlogn) and space complexity of O(1)
     */
public:
    int findTheDistanceValue(std::vector<int>& arr1, std::vector<int>& arr2, int d) 
    {
        std::sort(arr2.begin(), arr2.end());
        int distance = 0;
        
        for (int x : arr1) 
        {
            auto temp = std::lower_bound(arr2.begin(), arr2.end(), x - d);
            
            if (temp != arr2.end() && *temp <= x + d)
                continue;
            distance++;
        }
        return distance;
    }
};
