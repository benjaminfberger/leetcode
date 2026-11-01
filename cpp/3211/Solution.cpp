#include <string>
#include <vector>

class Solution 
{
    /*
     * Beats 85.4% of submissions with time complexity of O(2^n) and space complexity of O(n)
     */
public:
    std::vector<std::string> validStrings(int n) 
    {
        std::vector<std::string> ans;
        std::string current;
        backtrack(n, current, ans);
        return ans;
    }
private:
    void backtrack(int n, std::string& current, std::vector<std::string>& ans) 
    {
        if (current.length() == n) 
        {
            ans.push_back(current);
            return;
        }
        current.push_back('1');
        backtrack(n, current, ans);
        current.pop_back();

        if (current.empty() || current.back() == '1') 
        {
            current.push_back('0');
            backtrack(n, current, ans);
            current.pop_back();
        }
    }
};
