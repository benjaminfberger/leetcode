#include <vector>
class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    std::vector<int> plusOne(std::vector<int>& digits) 
    {
        for (int i = digits.size() - 1; i >= 0; i--) 
        {
            if (digits[i] < 9) 
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        digits.insert(digits.begin(), 1); 
        return digits;
    }
};