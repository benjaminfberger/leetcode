#include <string>

class Solution 
{
    /*
     * Beats 41.32% of submissions with time complexity of O(n) and space complexity of O(n)
     */
public:
    bool repeatedSubstringPattern(std::string s) 
    {
        std::string doubled = s + s;
        return doubled.substr(1, doubled.length() - 2).find(s) != std::string::npos;
    }
};
