#include <string>

class Solution
{
    /*
     * TLE with time complexity of O(n^2) and space complexity of O(1)
     */
public:
    int countMagicalPairs(std::string s) 
    {
        int unique = 0;
        for (int i = 0; i <= s.length() - 2; i++)
            for (int j = i; j <= s.length() - 2; j++)
                for (int k = j; k <= s.length() - 1; k++) 
                {
                    std::string s1 = s.substr(i, j - i + 1);
                    std::string s2 = s.substr(j + 1, k - j);
                    if (distinct(s1) == distinct(s2))
                        unique++;
                }
        return unique;
    }
private:
    int distinct(std::string s)
    {
        unsigned int mask = 0;
        int count = 0;
        for (char c : s)
        {
            unsigned int bit = 1U << (c - 'a');
            if (!(mask & bit)) {
                mask |= bit;
                count++;
            }
        }
        return count;
    }
};
