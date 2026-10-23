#include <vector>

class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    bool canPlaceFlowers(std::vector<int>& flowerbed, int n) 
    {
        if (n == 0) return true;
        
        int size = flowerbed.size();
        for (int i = 0; i < size; i++) 
            if (flowerbed[i] == 0) 
            {
                bool leftEmpty  = (i == 0) || (flowerbed[i - 1] == 0);
                bool rightEmpty = (i == size - 1) || (flowerbed[i + 1] == 0);
                
                if (leftEmpty && rightEmpty) 
                {
                    flowerbed[i] = 1;
                    n--;
                    if (n <= 0) return true;
                }
            }
        return n <= 0;
    }
};
