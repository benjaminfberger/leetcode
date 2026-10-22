#include <algorithm>
#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    double average(std::vector<int>& salary) 
    {
        sort(salary.begin(), salary.end());
        double ans = 0;
        for (int i = 1; i < size(salary) - 1; i++)
            ans += salary[i];
        return ans / (double)(size(salary) - 2);
    }
};
