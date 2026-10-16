#include <string>

class Solution 
{
    /*
     * Beats 60.08% of submissions with time complexity of O(n) and space complexity of O(1)
     */
public:
    bool judgeCircle(std::string moves) 
    {
        int x = 0;
        int y = 0;
        for (int i = 0; i < moves.length(); i++) 
        {
            if (moves[i] == 'U') 
            {
                y++;
                continue;
            }
            if (moves[i] == 'D') 
            {
                y--;
                continue;
            }
            if (moves[i] == 'R') 
            {
                x++;
                continue;
            }
            if (moves[i] == 'L') 
            {
                x--;
            }
        }
        return x == 0 && y == 0;
    }
};
