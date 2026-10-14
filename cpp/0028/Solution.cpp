
#include <string>

class Solution
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(n)
     */
public:
    int strStr(std::string haystack, std::string needle) 
    {
        size_t found = haystack.find(needle);
        
        return (found != std::string::npos) ? static_cast<int>(found) : -1;
    }
};
