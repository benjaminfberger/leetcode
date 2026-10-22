class Solution 
{
    /*
     * Beats 79.58% of solutions with time complexity of O(1) and space complexity of O(1)
     */
public:
    int countOdds(int low, int high) 
    {
        return (high + 1) / 2 - low / 2;
    }
};