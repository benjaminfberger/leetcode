#include <string>
#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n*l) and space complexity of O(m)
     */
public:
    std::string mapWordWeights(std::vector<std::string>& words, std::vector<int>& weights) 
    {
        std::string ans;
        for (const std::string& word : words) 
        {
            int total = 0;
        
            for (int i = 0; i < word.length(); i++)
                total += weights[word[i] - 'a'];

            int rem = total % 26;
            if (rem < 0)
                rem += 26; 

            ans += static_cast<char>('z' - rem);
        }
        return ans;
    }
};
