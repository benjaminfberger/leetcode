#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    bool lemonadeChange(std::vector<int>& bills) 
    {
        int bill5 = 0;
        int bill10 = 0;

        for (int n : bills) 
        {
            if (n == 5)
                bill5++;
            else if (n == 10) {
                if (bill5 == 0) 
                    return false;
                bill5--;
                bill10++;
            } 
            else {
                if (bill10 > 0 && bill5 > 0) {
                    bill10--;
                    bill5--;
                } 
                else if (bill5 >= 3)
                    bill5 -= 3;
                else
                    return false;
            }
        }
        return true;
    }
};
