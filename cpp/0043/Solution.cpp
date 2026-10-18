#include <string>
#include <vector>

class Solution 
{
    /*
     * Beats 72.77% of submissions with time complexity of O(n * m) and space complexity of O(n + m)
     */
public:
    std::string multiply(std::string num1, std::string num2) 
    {
        if (num1 == "0" || num2 == "0") return "0";
        int n = num1.size();
        int m = num2.size();

        std::vector<int> result(n + m, 0);
        
        for (int i = n - 1; i >= 0; i--)
            for (int j = m - 1; j >= 0; j--) {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                
                int p1 = i + j;
                int p2 = i + j + 1;
                
                int sum = mul + result[p2];
                
                result[p2] = sum % 10;
                result[p1] += sum / 10;
            }
        std::string res = "";
        for (int digit : result)
            if (!(res.empty() && digit == 0))
                res.push_back(digit + '0');

        return res;
    }
};
