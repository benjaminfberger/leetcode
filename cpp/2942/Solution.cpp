#include <string>
#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n*m) and space complexity of O(n)
     */
public:
    std::vector<int> findWordsContaining(std::vector<std::string>& words, char x) 
    {
        std::vector<int> ans; 
        for (int i = 0; i < std::size(words); i++)
            if (words[i].find(x) != std::string::npos)
                ans.push_back(i);
        return ans;
    }
};
