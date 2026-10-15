#include <string>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    int lengthOfLastWord(std::string s) 
    {
        int i = s.length() - 1;
        
        while (i >= 0 && s[i] == ' ')
            i--;
        
        int length = 0;
        while (i >= 0 && s[i] != ' ') 
        {
            length++;
            i--;
        }
        return length;
    }
};
