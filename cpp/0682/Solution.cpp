#include <string>
#include<vector>
class Solution 
{
    /*
     * Beats 100% of submissions with time complexity of O(n) and space complexity of O(n)
     */
public:
    int calPoints(std::vector<std::string>& operations) 
    {
        std::vector<int> runningTotal;
        int total = 0;
        for (int i = 0; i < size(operations); i++) 
        {
            if (operations[i] == "C") {
                runningTotal.pop_back();
                continue;
            }
            if (operations[i] == "D") 
            {
                runningTotal.push_back(runningTotal[size(runningTotal) - 1] * 2);
                continue;
            }
            if (operations[i] == "+") 
            {
                runningTotal.push_back(runningTotal[size(runningTotal) - 1] + runningTotal[size(runningTotal) - 2]);
                continue;
            }
            runningTotal.push_back(stoi(operations[i]));
        }
        for (int i = 0; i < size(runningTotal); i++)
            total += runningTotal[i];
        
        return total;
    }
};