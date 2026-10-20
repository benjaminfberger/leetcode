#include <string>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(max(n, m)) and space complexity of O(max(n, m))
     */
public:
    std::string addBinary(std::string a, std::string b) 
    {
        std::string result;
        int aP = a.length() - 1; 
        int bP = b.length() - 1;
        int carry = 0;

        while (aP >= 0 || bP >= 0 || carry == 1) {
            int bA = (aP >= 0) ? a[aP] - '0' : 0;
            int bB = (bP >= 0) ? b[bP] - '0' : 0;

            int sum = bA ^ bB ^ carry; 
            carry = (bA & bB) | (bA & carry) | (bB & carry);

            result.push_back(sum + '0');

            aP--;
            bP--;
        }
        reverse(result.begin(), result.end());
        
        return result;
    }
};
