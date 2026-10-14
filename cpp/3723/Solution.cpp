#include <string>

class Solution 
{
    /*
     * Beats 79.7% of submissions with time complexity of O(num) and space complexity of O(num)
     */
public:
    std::string maxSumOfSquares(int num, int sum) 
    {
        if (sum > 9 * num) 
            return "";
        
        int div = sum / 9;
        int rem = sum % 9;

        std::string result(div, '9'); 
        
        if (rem > 0)
            result += std::to_string(rem);
        
        int zeros_needed = num - result.length();
        if (zeros_needed > 0)
            result.append(zeros_needed, '0');
        
        return result;

    }
};