class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(logn) and space complexity of O(1)
     */
public:
    double myPow(double x, int n) 
    {
        if (n == 0) 
            return 1.0;
        unsigned int exp = n;
        if (n < 0)
            exp = -exp; 
        double res = 1.0;
        while (exp > 0) 
        {
            if ((exp & 1) == 1) 
            {
                res = res * x;
            }
            x = x * x;
            exp = exp >> 1;
        }
        if (n < 0)
            return 1.0 / res;
        return res;
    }
};
