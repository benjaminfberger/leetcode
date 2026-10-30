#include <string>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(n)
     */
public:
    std::string defangIPaddr(std::string address) 
    {
        std::string defang;
        for (char c : address)
            if (c == '.')
                defang += "[.]";
            else
                defang += c;
        return defang;
    }
};
