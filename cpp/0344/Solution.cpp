#include <vector>

class Solution 
{
    /*
     * Beats 100% os submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    void reverseString(std::vector<char>& s) 
    {
        int left = 0;
        int right = s.size() - 1;

        while (left < right) 
        {
            std::swap(s[left], s[right]);
            left++;
            right--;
        }
    }
};